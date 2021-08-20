using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Swin_Adventure;

namespace Swin_Adventure
{
    [TestFixture]
    public class IdentifiableObjectTest
    {
        private IdentifiableObject _testableObject;
        private string _testableString;


        [SetUp]
        public void SetUp()
        {
            _testableString = "Some string.";
            _testableObject = new IdentifiableObject();
            _testableObject.AddIdentifier(_testableString);
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_testableObject.AreYou(_testableString));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_testableObject.AreYou("not some string."));
        }

        [Test]
        public void TestCaseInsensitive()
        {
            Assert.IsTrue(_testableObject.AreYou("SOME STRING."));
        }

        [Test]
        public void TestFirstID()
        {
            _testableObject.AddIdentifier("second");
            _testableObject.AddIdentifier("third");
            _testableObject.AddIdentifier("fourth");
            Assert.AreEqual("some string.", _testableObject.FirstId);
            Assert.AreNotEqual("second", _testableObject.FirstId);
        }

        [Test]
        public void TestAddIdentifier()
        {
            string newString = "hey this is a NEW STRING!";
            _testableObject.AddIdentifier(newString);
            Assert.IsTrue(_testableObject.AreYou(newString));
        }

    }
}