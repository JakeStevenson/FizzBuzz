using FizzBuzzLibrary;
using FizzBuzzLibrary.Rules;
using Moq;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class TestRenderer
    {
        //A rule with built-in guaranteed exception for testing.
        class BadRule : IRule
        {
            public int Number { get { return 0; }}
            public string ProcessRule(int i)
            {
                //Will cause an error dividing by zero.
                return (i%Number).ToString();
            }
        }
        //Test that renderer runs through all injected rules
        [Test]
        public void TestDefaultOutput()
        {
            var rule1 = new Mock<IRule>();
            rule1.Setup(s => s.ProcessRule(It.IsAny<int>())).Returns("FIZZ");
            var rule2 = new Mock<IRule>();
            rule2.Setup(s => s.ProcessRule(It.IsAny<int>())).Returns("BUZZ");
            var renderer = new FizzBuzzLibrary.FizzBuzzRenderer(new IRule[]{rule1.Object,rule2.Object});
            var output = renderer.FizzBuzzOutput(1);
            Assert.That(output == "FIZZBUZZ", "Expected 'FIZZBUZZ', got {0}", output);
        }
        //Test to make sure output isn't stopped if a bad rule gets injected
        [Test]
        public void TestBadRule()
        {
            var rules = new IRule[] {new BadRule(), new FizzRule(), new BuzzRule()};
            var renderer = new FizzBuzzRenderer(rules);

            var output = renderer.FizzBuzzOutput(15);
            Assert.That(output == "FizzBuzz");
        }
    }
}
