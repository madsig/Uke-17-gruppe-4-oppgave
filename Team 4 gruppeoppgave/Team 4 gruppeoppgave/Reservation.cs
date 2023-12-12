

namespace Team_4_gruppeoppgave
{
    internal class Reservation
    {
        private string _resName;
        private string _resPhoneNumber;
        private int _resGuests;
        private DateTime _resStartTime;
        private string _description;

        public Reservation(string resName, string resPhoneNumber, int resGuests, DateTime resStartTime)
        {
            _resName = resName;
            _resPhoneNumber = resPhoneNumber;
            _resGuests = resGuests;
            _resStartTime = resStartTime;
            _description = $"Reservert bord til {resGuests} personer {resStartTime.ToString("dd/MM/yyyy")} kl. {resStartTime.ToString("HH:mm")}";
        }

        public string GetDescription()
        {
            return _description;
        }

       

    }

}
