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
    public class PlayerTest
    {
        // Private fields for this test goes here
        private Player _testablePlayer;
        private Item _testItem1;
        private Item _testItem2;
        private Item _testItem3;
        private Inventory _testableInventory;

        [SetUp]
        public void SetUp()
        {
            // Initialising a Player and its Inventory
            _testablePlayer = new Player("Link", "A hero");
            _testableInventory = new Inventory();

            // Initialising Item objects
            _testItem1 = new Item(new string[] { "bucket", "pail" }, "Bucket", "A plastic bucket");
            _testItem2 = new Item(new string[] { "mop" }, "Mop", "A mop with wooden handle");
            _testItem3 = new Item(new string[] { "brush", "paint", "paintbrush" }, "Paint brush", "A small paint brush");

            // Adding the items into Inventory
            _testableInventory.Put(_testItem1);
            _testableInventory.Put(_testItem2);
            _testableInventory.Put(_testItem3);
        }

        [Test]
        // Test that player responds correctly to "Are You" requests based on
        // its default identifiers (me and inventory)
        public void TestIdentifiable()
        {
            Assert.IsTrue(_testablePlayer.AreYou("me"));
            Assert.IsTrue(_testablePlayer.AreYou("inventory"));
        }

        [Test]
        // Test that the player can locate items in its inventory,
        // returns items the player has, and the item remains in player's inventory
        public void TestLocateItems()
        {

        }

        [Test]
        // Test that player returns itself if asked to locate "me" or "inventory"
        public void TestLocatePlayer()
        {

        }

        [Test]
        // The player returns a null/nil object if asked to locate something 
        // it does not have
        public void TestLocateNothing()
        {

        }

        [Test]
        // The player's full description contains the text "You are carrying: "
        // and the short descriptions of the items the player has
        // (from its inventory's item list)
        public void TestFullDescription()
        {

        }
    }
}
