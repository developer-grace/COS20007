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
        private String _gemDescription;
        private Item _testableItem;
        private Bag _testableBag;

        [SetUp]
        public void SetUp()
        {
            _testLookCommand = new LookCommand(new string[] { "" });
            _testablePlayer = new Player("Link", "A hero");
            _gemDescription = "a bright red gem";
            _testableItem = new Item(new string[] { "gem" }, "gem", _gemDescription);
            _testableBag = new Bag(new string[] { "bag" }, "bag", "a blue canvas backpack");
            _testablePlayer.Inventory.Put(_testableItem);
        }

        [Test]
        public void TestLookAtMe()
        {
            _testLookCommand.Execute(_testablePlayer, new string[] { "look", "at", "inventory" });
            Assert.AreEqual("A hero", _testLookCommand.Execute(_testablePlayer, "look at inventory".Split()));
        }

        [Test]
        public void TestLookAtGem()
        {
            //_testLookCommand.Execute(_testablePlayer, new string[] { "look", "at", "gem" });

            Assert.AreEqual(_gemDescription, _testLookCommand.Execute(_testablePlayer, new string[] { "look", "at", "gem" }));

        }

        [Test]
        public void TestLookAtUnk()
        {
            Assert.AreEqual("I can't find the Myki", _testLookCommand.Execute(_testablePlayer, "look at Myki".Split()));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            Assert.AreEqual("a bright red gem", _testLookCommand.Execute(_testablePlayer, "look at gem in me".Split()));
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            _testablePlayer.Inventory.Put(_testableBag);
            _testableBag.Inventory.Put(_testableItem);

            Assert.AreEqual("a bright red gem", _testLookCommand.Execute(_testablePlayer, "look at gem in bag".Split()));
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            Assert.AreEqual("I can't find the bag", _testLookCommand.Execute(_testablePlayer, "look at gem in bag".Split()));
        }

        [Test]
        public void TestLoookAtNoGeminBag()
        {
            _testablePlayer.Inventory.Put(_testableBag);

            Assert.AreEqual("I can't find the gem", _testLookCommand.Execute(_testablePlayer, "look at gem in bag".Split()));

        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.AreEqual("I don't know how to look like that", _testLookCommand.Execute(_testablePlayer, "look around".Split()));
            Assert.AreEqual("I don't know how to look like that", _testLookCommand.Execute(_testablePlayer, "hello".Split()));
            Assert.AreEqual("What do you want to look in?", _testLookCommand.Execute(_testablePlayer, "look at a at b".Split()));
        }
    }
}
