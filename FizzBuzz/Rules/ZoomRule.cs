using System;
using FizzBuzzLibrary.Rules;

namespace FizzBuzz.Rules
{
    class ZoomRule : IRule
    {
        public int Number { get { return 10; } }
        public string ProcessRule(int i)
        {
            var square = Math.Sqrt(i);
            return square % 1 == 0 ? "Zoom" : null;
        }
    }
}
