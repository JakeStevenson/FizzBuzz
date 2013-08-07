using System;
using System.Collections.Generic;
using FizzBuzzLibrary;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class TestRenderer
    {
        [Test]
        public void TestDefaultOutput()
        {
            var renderer = new FizzBuzzRenderer(new List<FizzBuzzRule>()
                                                    {
                                                        (int i) => "works"
                                                    });
            Assert.That(renderer.FizzBuzzOutput(1) == "works");
        }

        [Test]
        public void TestOutputsInOrder()
        {
            var renderer = new FizzBuzzRenderer(new List<FizzBuzzRule>()
                                                    {
                                                        (int i) => "Z",
                                                        (int i) => "A"
                                                    });
            Assert.That(renderer.FizzBuzzOutput(1) == "ZA");
        }
    }
}
