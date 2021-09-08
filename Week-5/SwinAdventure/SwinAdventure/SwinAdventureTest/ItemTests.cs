using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwinAdventure;

namespace SwinAdventureTest
{
    [TestFixture]
    public class ItemTests
    {
        private Item _testableItem;
        private string[] _testStrings = new string[] { "Test string 1", "Test Item 2", "Test Item 3" };



        [SetUp]
        public void SetUp()
        {
            _testableItem = new Item(_testStrings, "Test Item", "This is a test item");
        }

        [Test]
        public void TestIdentifiable()
        {
            Assert.IsTrue(_testableItem.AreYou("Test string 1"));
            Assert.IsTrue(_testableItem.AreYou("Test string 2"));
            Assert.IsTrue(_testableItem.AreYou("Test string 3"));
            Assert.IsFalse(_testableItem.AreYou("Test string 4"));

        }
    }
}

