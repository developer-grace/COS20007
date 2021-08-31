using System;

namespace CounterTest
{
    class Program
    {
        private static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
            {
                Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
            }
        }

        private static void PrintTime(Clock myClock)
        {
            Console.WriteLine("The time is {0} according to {1}", myClock, myClock.Name);
        }

        public static void Main(string[] args)
        {
            Counter[] myCounters = new Counter[3];
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            for (int i = 0; i < 4; i++)
            {
                myCounters[0].Increment();
            }

            for (int i = 0; i < 9; i++)
            {
                myCounters[1].Increment();
            }

            PrintCounters(myCounters);
            myCounters[2].Reset();
            PrintCounters(myCounters);

            Clock myClock = new Clock();
            Console.WriteLine("A clock is created");
            PrintTime(myClock);
            myClock.Tick();
            PrintTime(myClock);
            Console.WriteLine("Now the time will be set to 23:59:59");
            myClock.SetTime("23:59:59");
            PrintTime(myClock);
            myClock.Tick();
            PrintTime(myClock);
            myClock.Tick();
            PrintTime(myClock);
        }
    }
}
