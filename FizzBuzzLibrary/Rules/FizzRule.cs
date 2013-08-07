namespace FizzBuzzLibrary.Rules
{
    public class FizzRule : IRule
    {
        public int Number { get { return 3; }}

        public string ProcessRule(int i)
        {
            return i % Number == 0 ? "Fizz" : null;
        }
    }
    public class BuzzRule : IRule
    {
        public int Number { get { return 5; }}

        public string ProcessRule(int i)
        {
            return i % Number == 0 ? "Buzz" : null;
        }
    }
}
