namespace FizzBuzzLibrary.Rules
{
    public class FizzRule : IRule
    {
        public string ProcessRule(int i)
        {
            return i % 3 == 0 ? "Fizz" : null;
        }
    }
    public class BuzzRule : IRule
    {
        public string ProcessRule(int i)
        {
            return i % 5 == 0 ? "Buzz" : null;
        }
    }
}
