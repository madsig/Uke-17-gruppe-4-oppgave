namespace Team_4_gruppeoppgave
{
    internal class Restaurant
    {
        private List<Reservation> _reservations;
        private List<Table> _tables = new List<Table>();
        private string _restaurantName;
        private int _openingTime;
        private int _closingTime;

        public Restaurant(string name, int openingTime, int closingTime)
        {
            _restaurantName = name;
            _openingTime = openingTime;
            _closingTime = closingTime;
        }


        public void AddTable(string name, int seatCount)
        {
            var table = new Table(name, seatCount);
            _tables.Add(table);
            Console.WriteLine(_tables);
            
        }

        public void CreateReservation(string resName, string resPhoneNumber, int resGuests, DateTime resStartTime)
        {
            var bestTable = GetAvailableTable(resGuests, resStartTime);
            if (bestTable == null)
            {
                Console.WriteLine($"Vi beklager! Det er ikke ledig bord til {resGuests} personer {resStartTime.ToString("dd/MM/yyyy")} kl. {resStartTime.ToString("HH:mm")}");
                return;
            }
            else
            {
                _reservations.Append(new Reservation(resName, resPhoneNumber, resGuests, resStartTime));
                Console.WriteLine($"Reservert bord til {resGuests} personer {resStartTime.ToString("dd/MM/yyyy")} kl. {resStartTime.ToString("HH:mm")}");
            }

            Console.WriteLine("Nothing happened");





        }

        private Table GetAvailableTable(int guestCount, DateTime resStartTime)
        {
            var unbookedTables = _tables.Where<Table>(t => t.IsAvailable(resStartTime));
            var bigEnoughTables = unbookedTables.Where<Table>(t => t.SeatCount >= guestCount);


            Table bestTable = null;
            var minSeats = guestCount;

            while (bestTable == null || minSeats >= 10)
            {
                foreach (var table in bigEnoughTables)
                {
                    if (table.SeatCount == minSeats) bestTable = table;
                }

                minSeats++;
            }


            return bestTable;
        }


        /*
         * Table[]
         * Reservation[]
         *
         * AddTable() => Table
         * MakeReservation() => Reservation
         * GetSchedule() => Reservation
         */
    }
}
