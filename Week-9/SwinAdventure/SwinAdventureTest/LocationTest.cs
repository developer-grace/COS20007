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
    public class LocationTest
    {
        // private fields go here
        private Location _testLocation;
        private Player _testPlayer;
        private Item _testGem;
        private Item _testSword;


        [SetUp]
        public void SetUp()
        {
            // Initialising stuff
            _testLocation = new Location(new string[] { "here", "house" }, "Hero's House", "House where the hero resides");

            _testPlayer = new Player("Link", "The hero", _testLocation);

            _testGem = new Item(new string[] { "gem" }, "gem", "a bright red gem");
            _testSword = new Item(new string[] { "sword" }, "sword", "a metal sword with sheath");



            // Putting items into a location
            _testLocation.PutItem(_testGem);
            _testLocation.PutItem(_testSword);

        }

        [Test]
        // Test whether Location can identify themselves
        public void TestAreYou()
        {
            Assert.IsTrue(_testLocation.AreYou("here"));
        }

        [Test]
        // Test whether Locations can locate items they have
        public void TestLocateItem()
        {
            Assert.AreEqual(_testSword, _testLocation.FetchItem("sword"));
        }


        [Test]
        // Test whether Players can locate items in their location
        public void TestPlayerLocation()
        {
            Assert.AreEqual(_testLocation.ToString(), _testPlayer.WhereAreYou());
        }

        [Test]
        // Test whether Players can locate items in their location
        public void TestPlayerLocateItem()
        {
            Assert.AreEqual(_testGem, _testPlayer.Locate("gem"));
        }
    }
}
