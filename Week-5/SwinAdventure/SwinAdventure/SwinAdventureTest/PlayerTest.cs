using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwinAdventure;

namespace SwinAdventureTest
{
    // Private fields for this test goes here


    [TestFixture]
    public class PlayerTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        // Test that player responds correctly to "Are You" requests based on
        // its default identifiers (me and inventory)
        public void TestIdentifiable()
        {

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
