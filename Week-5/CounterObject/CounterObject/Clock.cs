using System;
namespace CounterTest
{
    public class Clock
    {
        private Counter _hours;
        private Counter _minutes;
        private Counter _seconds;
        private string _name;

        public Clock() : this("This Ol' Clock")
        {
        }

        public Clock(string name)
        {
            _name = name;
            this.Reset();
        }

        private void Reset()
        {
            _hours = new Counter("hours");
            _minutes = new Counter("minutes");
            _seconds = new Counter("seconds");
        }

        public void Tick()
        {
            _seconds.Increment();
            if(_seconds.Ticks == 60)
            {
                _seconds.Reset();
                _minutes.Increment();
            }

            if (_minutes.Ticks == 60)
            {
                _minutes.Reset();
                _hours.Increment();
            }

            if (_hours.Ticks == 24)
            {
                _hours.Reset();
            }
        }

        public void SetTime(string s)
        {
            string[] array = s.Split(":");

            _hours = new Counter("hours", int.Parse(array[0]));
            _minutes = new Counter("minutes", int.Parse(array[1]));
            _seconds = new Counter("seconds", int.Parse(array[2]));
        }

        public override string ToString()
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
