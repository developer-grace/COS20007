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

        [SetUp]
        public void SetUp()
        {
            // Initialising a Player
            _testablePlayer = new Player("Link", "A hero");

            // Initialising Item objects
            _testItem1 = new Item(new string[] { "bucket", "pail" }, "Bucket", "A plastic bucket");
            _testItem2 = new Item(new string[] { "mop" }, "Mop", "A mop with wooden handle");
            _testItem3 = new Item(new string[] { "brush", "paint", "paintbrush" }, "Paint brush", "A small paint brush");

            // Adding the items into Inventory
            _testablePlayer.Inventory.Put(_testItem1);
            _testablePlayer.Inventory.Put(_testItem2);
            _testablePlayer.Inventory.Put(_testItem3);
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
            // Asking the Player to locate "mop"
            _testablePlayer.Locate("mop");
            // Checking that "mop" is still in the player's inventory
            Assert.IsTrue(_testablePlayer.Inventory.HasItem("mop"));
        }

        [Test]
        // Test that player returns itself if asked to locate "me" or "inventory"
        public void TestLocatePlayer()
        {
            // Asking the Player to locate itself, making sure it returns itself
            _testablePlayer.Locate("me");
            Assert.AreEqual(_testablePlayer, _testablePlayer.Locate("me"));
            _testablePlayer.Locate("inventory");
            Assert.AreEqual(_testablePlayer, _testablePlayer.Locate("inventory"));
        }

        [Test]
        // The player returns a null/nil object if asked to locate something 
        // it does not have
        public void TestLocateNothing()
        {
            _testablePlayer.Locate("nonexistent item");
            Assert.IsNull(_testablePlayer.Locate("nonexistent item"));
        }

        [Test]
        // The player's full description contains the text "You are carrying: "
        // and the short descriptions of the items the player has
        // (from its inventory's item list)
        public void TestFullDescription()
        {
            Assert.AreEqual(@"Bucket (bucket)
Mop (mop)
Paint brush (brush)", _testablePlayer.Inventory.ItemList);
        }
    }
}
