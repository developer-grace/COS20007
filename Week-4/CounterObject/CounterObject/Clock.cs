using System;
namespace CounterTest
{
    public class Clock
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        private string _name;

        public Clock()
        {
        }
        public Clock(string name)
        {
        }

        private void Reset()
        {
            _hours = 00;
            _minutes = 00;
            _seconds = 00;
        }

        public void Tick()
        {

        }

        public void setTime(string s)
        {

        }

        public string toString()
        {
            return $"{_hours}:{_minutes}:{_seconds}";
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
