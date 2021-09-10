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
    public class InventoryTest
    {
        // Private fields for this test goes here
        private Inventory _testableInventory;
        private Item _testItem1;
        private Item _testItem2;
        private Item _testItem3;


        [SetUp]
        public void SetUp()
        {
            // Initialising the Inventory
            _testableInventory = new Inventory();

            // Initialising Item objects
            _testItem1 = new Item(new string[] { "bucket", "pail"}, "Bucket", "A plastic bucket");
            _testItem2 = new Item(new string[] { "mop" }, "Mop", "A mop with wooden handle");
            _testItem3 = new Item(new string[] { "brush", "paint", "paintbrush" }, "Paint brush", "A small paint brush");

            // Adding the items into Inventory
            _testableInventory.Put(_testItem1);
            _testableInventory.Put(_testItem2);
            _testableInventory.Put(_testItem3);
        }

        [Test]
        // Checking if the Inventory has items put in it
        public void TestFindItem()
        {
            Assert.IsTrue(_testableInventory.HasItem("bucket"));
            Assert.IsFalse(_testableInventory.HasItem("something"));
        }

        [Test]
        // Make sure Inventory doesn't have items it does not contain
        public void TestNoItemFind()
        {
            // Inventory doesn't have any item named "mouse"
            Assert.IsFalse(_testableInventory.HasItem("mouse"));
        }

        [Test]
        // Returns items it has, and the item remains in the inventory
        public void TestFetchItem()
        {
            // Check that Fetch returns something after telling Inventory to Fetch the "mop" item
            Assert.IsNotNull(_testableInventory.Fetch("mop"));

            // After Fetching the "mop" item, check that the "mop" is still in Inventory
            Console.WriteLine(_testableInventory.HasItem("mop"));
            Assert.IsTrue(_testableInventory.HasItem("mop"));

        }

        [Test]
        // Returns items it has, and the item is no longer in the inventory
        public void TestTakeItem()
        {
            _testableInventory.Take("mop");
            // After Taking the "mop" item, check that the "mop" is not in Inventory anymore
            Assert.IsFalse(_testableInventory.HasItem("mop"));
        }

        [Test]
        // TODO: Find out what is the expected output based on the requirements
        // Returns a list of strings with one row per item
        // The rows contain tab indented short descriptions of the items in the inventory
        public void TestItemList()
        {

            // Use a string literal so that the expected input can be multiline
            // @"blah" is a string literal
            Assert.AreEqual(@"Bucket (bucket)
Mop (mop)
Paint brush (brush)", _testableInventory.ItemList);
        }
    }
}
