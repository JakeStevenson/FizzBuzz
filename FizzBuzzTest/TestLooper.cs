using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class TestLooper
    {
        private int _calls;
        private FizzBuzzLibrary.FizzBuzzLooper _looper;
        [SetUp]
        public void SetupLooper()
        {
            _calls = 0;
            var renderer = new Mock<FizzBuzzLibrary.FizzBuzzRenderer>();
            renderer.Setup(r => r.FizzBuzzOutput(It.IsAny<int>())).Returns("Output").Callback(() => _calls++);
            _looper = new FizzBuzzLibrary.FizzBuzzLooper(renderer.Object);
        }

        [Test]
        public void TestForwardArgs()
        {
           _looper.Loop(1,10);
            Assert.That(_calls == 10, "Expected 10 calls, got {0}", _calls);
        }
        [Test]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestBackwardArgs()
        {
           _looper.Loop(10,1);
            Assert.That(_calls==0, "Expected no calls, got {0}", _calls);
        }

        [Test]
        public void TestSameArgs()
        {
           _looper.Loop(10,10);
            Assert.That(_calls==1, "Expected no calls, got {0}", _calls);
        }
    }
}
