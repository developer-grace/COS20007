using NUnit.Framework;
using CounterTest;

namespace ClockTests
{
    [TestFixture]
    public class Tests
    {
        private Counter _testableCounter;
        private string _testableName;

        [SetUp]
        public void Setup()
        {
            _testableName = "My counter";
            _testableCounter = new Counter(_testableName);
        }


        // Test that counter is initialised to zero
        [Test]
        public void TestInitialisatoin()
        {
            Assert.AreEqual(_testableName, _testableCounter.Name);
            Assert.AreEqual(0, _testableCounter.Ticks);
        }


        // Test that incremeting the counter adds one to the count
        [Test]
        public void TestIncrement()
        {
            _testableCounter.Increment();
            Assert.AreEqual(1, _testableCounter.Ticks);
        }

        // Test that multiple increments work
        [Test]
        public void TestMultipleIncrement()
        {
            _testableCounter.Increment();
            Assert.AreEqual(1, _testableCounter.Ticks);
            _testableCounter.Increment();
            Assert.AreEqual(2, _testableCounter.Ticks);
            _testableCounter.Increment();
            Assert.AreEqual(3, _testableCounter.Ticks);
        }


        // Test resets work
        [Test]
        public void TestReset()
        {
            _testableCounter.Increment();
            Assert.AreEqual(1, _testableCounter.Ticks);
            _testableCounter.Increment();
            Assert.AreEqual(2, _testableCounter.Ticks);
            _testableCounter.Increment();
            Assert.AreEqual(3, _testableCounter.Ticks);
            _testableCounter.Increment();
            Assert.AreEqual(4, _testableCounter.Ticks);

            _testableCounter.Reset();
            Assert.AreEqual(0, _testableCounter.Ticks);
        }
    }
}
