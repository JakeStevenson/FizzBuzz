using FizzBuzzLibrary.Rules;
using NUnit.Framework;

namespace FizzBuzzTest.Rules
{
    [TestFixture]
    public class TestBuzzRule
    {
        [Test]
        public void TestBuzz()
        {
            var rule = new BuzzRule();
            Assert.That(rule.ProcessRule(5) == "Buzz", "5 should Fizz");
            Assert.That(string.IsNullOrEmpty(rule.ProcessRule(6)), "6 should be null");
        }
    }
}
