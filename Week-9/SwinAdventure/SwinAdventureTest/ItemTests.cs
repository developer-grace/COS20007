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
        // Private fields for this test goes here
        private Item _testableItem;

        [SetUp]
        public void SetUp()
        {
            // Initialising the private fields, creating Objects in SetUp
            _testableItem = new Item(new string[] { "shovel", "spade", "gardening tool" }, "Shovel", "A metal shovel with wooden handle");
        }

        [Test]
        public void TestIdentifiable()
        {
            // Check that the item responds correctly to "AreYou" requests based on the identifiers it is created with
            Assert.IsFalse(_testableItem.AreYou("sword"));
            
        }

        [Test]
        public void TestShortDescription()
        {
            // Check that the game object's short description returns the string "a name (first id)"
            Assert.AreEqual("Shovel (shovel)", _testableItem.ShortDescription);

        }

        [Test]
        public void TestFullDescription()
        {
            // Check that it returns the item's description
            Assert.AreEqual("A metal shovel with wooden handle", _testableItem.FullDescription);
        }
    }
}

