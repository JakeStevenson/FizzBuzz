using FizzBuzzLibrary.Rules;
using NUnit.Framework;

namespace FizzBuzzTest.Rules
{
    [TestFixture]
    public class TestFizzRule
    {
        [Test]
        public void TestFizz()
        {
            var rule = new FizzRule();
            Assert.That(rule.ProcessRule(3) == "Fizz", "3 should Fizz");
            Assert.That(string.IsNullOrEmpty(rule.ProcessRule(2)), "2 should be null");
        }
    }
}
