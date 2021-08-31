using NUnit.Framework;
using CounterTest;

namespace ClockTests
{
    [TestFixture]
    public class ClockTests
    {
        private Clock _testableClock;
        private string _testableName;
        private string _testableTime;

        [SetUp]
        public void Setup()
        {
            _testableName = "Unit Testing Clock";
            _testableClock = new Clock(_testableName);
            _testableTime = "23:59:08";
        }

        [Test]
        public void TestInitialisation()
        {
            Assert.AreEqual(_testableName, _testableClock.Name);
        }

        [Test]
        public void TestTime()
        {
            _testableClock.SetTime(_testableTime);
            Assert.AreEqual(_testableTime, _testableClock.ToString());
        }

        [Test]
        public void TestReset()
        {
            Assert.AreEqual("00:00:00", _testableClock.ToString());
        }

        [Test]
        public void TestTick()
        {
            Assert.AreEqual("00:00:00", _testableClock.ToString());
            _testableClock.Tick();
            Assert.AreEqual("00:00:01", _testableClock.ToString());
            _testableClock.Tick();
            Assert.AreEqual("00:00:02", _testableClock.ToString());
            _testableClock.Tick();
            Assert.AreEqual("00:00:03", _testableClock.ToString());
        }


        [Test]
        public void TestLotsOfTicks()
        {
            for(int i = 0; i < 123; i++)
            {
                _testableClock.Tick();
            }
            Assert.AreEqual("00:02:03", _testableClock.ToString());

            for (int i = 0; i < 3600; i++)
            {
                _testableClock.Tick();
            }
            Assert.AreEqual("01:02:03", _testableClock.ToString());

            Assert.Pass();
        }

        [Test]
        public void TestRunOver()
        {
            _testableClock.SetTime("23:59:59");
            _testableClock.Tick();
            Assert.AreEqual("00:00:00", _testableClock.ToString());
            _testableClock.Tick();
            Assert.AreEqual("00:00:01", _testableClock.ToString());
        }


    }
}