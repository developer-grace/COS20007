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
    public class LookCommandTest
    {
        // private fields go here
        private Player _testablePlayer;
        private LookCommand _testLookCommand;
        private Item _testableItem;
        private Bag _testableBag;

        [SetUp]
        public void SetUp()
        {
            _testLookCommand = new LookCommand(new string[] { "" });
            _testablePlayer = new Player("Link", "A hero");
            _testableItem = new Item(new string[] { "gem" }, "gem", "a bright red gem");
            _testableBag = new Bag(new string[] { "backpack" }, "backpack", "a blue canvas backpack");
        }

        [Test]
        public void TestLookAtMe()
        {
            _testLookCommand.Execute(_testablePlayer, new string[] { "look", "at", "inventory" });
            Assert.AreEqual(_testablePlayer, _testLookCommand.Execute(_testablePlayer, new string[] { "look", "at", "inventory" }));
        }

        [Test]
        public void TestLookAtGem()
        {
            _testLookCommand.Execute(_testablePlayer, new string[] { "look", "at", "gem" });
            Assert.AreEqual(_testableItem, _testLookCommand.Execute(_testablePlayer, new string[] { "look", "at", "gem" }));
        }

        //[Test]
        //public void TestLookAtUnk()
        //{
        //    // code goes here
        //}

        //[Test]
        //public void TestLookAtGemInMe()
        //{
        //    // code goes here
        //}

        //[Test]
        //public void TestLookAtGemInBag()
        //{
        //    // code goes here
        //}

        //[Test]
        //public void TestLookAtGemInNoBag()
        //{
        //    // code goes here
        //}

        //[Test]
        //public void TestLoookAtNoGeminBag()
        //{
        //    // code goes here
        //}

        //[Test]
        //public void TestInvalidLook()
        //{
        //    // code goes here
        //}
    }
}
