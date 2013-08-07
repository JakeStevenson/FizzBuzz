namespace FizzBuzzLibrary.Rules
{
    public interface IRule
    {
        int Number { get; }
        string ProcessRule(int i);
    }
}
