namespace Team_4_gruppeoppgave
{
    internal class Table
    {
        public int SeatCount { get; private set; }
        private string _name;
        private DateTime _startTime = new DateTime(2023, 12, 24, 16, 0, 0);
        private DateTime _bookedTime;
        private DateTime _endTime;
        
        public Table(string name, int seatCount)
        {
            _name = name;
            SeatCount = seatCount;
        }


        public bool IsAvailable(DateTime desiredTime)
        {

            if (desiredTime >= _startTime && desiredTime <= _endTime) return true;
            return false;
        }


    }
}
