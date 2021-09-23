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
    public class BagTest
    {
        // Add private fields here
        private Bag _testBag;
        private Bag _testGunBag;
        private Item _testItem1;
        private Item _testItem2;
        
        [SetUp]
        public void SetUp()
        {
            // Initialising Bags
            _testBag = new Bag(new string[] { "bag", "weapons bag", "knife bag" }, "Weapons Bag", "Bag that contains hand held weapons");
            _testGunBag = new Bag(new string[] { "bag", "glock" }, "Gun Bag", "Bag that contains guns");

            // Initialising Items
            _testItem1 = new Item(new string[] { "machete", "knife" }, "Knife", "A machete");
            _testItem2 = new Item(new string[] { "pistol" }, "Pistol", "A pistol");

            // Adding the items into Bags
            _testBag.Inventory.Put(_testItem1);
            _testGunBag.Inventory.Put(_testItem2);

            // Putting GunBag into Bag
            _testBag.Inventory.Put(_testGunBag);
        }

        [Test]
        public void TestBagLocateItems()
        {
            // Check that Locate returns items the bag has
            Assert.AreEqual(_testItem1, _testBag.Locate("machete"));

            // Check that the item remains in the Bag's Inventory
            Assert.IsTrue(_testBag.Inventory.HasItem("machete"));
        }

        [Test]
        public void TestBagLocateItself()
        {
            // Asking GunBag to locate itself should return GunBag
            Assert.AreEqual(_testGunBag, _testGunBag.Locate("bag"));
        }

        [Test]
        public void TestBagLocateNothing()
        {
            Assert.IsNull(_testGunBag.Locate("inexistent item"));
        }

        [Test]
        public void TestBagFullDesc()
        {
            Assert.AreEqual("In the Gun Bag you can see: Pistol (pistol)", _testGunBag.FullDescription);
        }

        [Test]
        public void TestBagInBag()
        {
            // asking b1 to locate b2
            Assert.AreEqual(_testGunBag, _testBag.Locate("glock"));
            // asking b1 to locate other items in b1
            Assert.AreEqual(_testItem1, _testBag.Locate("knife"));
            // asking b1 to locate items in b2, where it should fail
            Assert.AreNotEqual(_testItem2, _testBag.Locate("pistol"));
        }
    }
}
