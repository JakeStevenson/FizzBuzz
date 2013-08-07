using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class TestRenderer
    {
        [Test]
        public void TestDefaultOutput()
        {
            var renderer = new FizzBuzzLibrary.FizzBuzzRenderer();
            Assert.That(renderer.FizzBuzzOutput(3) == "Fizz", "Expected 'Fizz' for 3.");
            Assert.That(renderer.FizzBuzzOutput(5) == "Buzz", "Expected 'Buzz' for 5.");
            Assert.That(renderer.FizzBuzzOutput(15) == "FizzBuzz", "Expected 'FizzBuzz' for 15.");

        }
    }
}
