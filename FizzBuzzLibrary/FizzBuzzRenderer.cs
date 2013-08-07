using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLibrary
{
    //Could really just use Func<int,string>, but expecing the client API to use that is painful.
    public delegate string FizzBuzzRule(int i);
    public class FizzBuzzRenderer
    {
        private List<FizzBuzzRule> _rules = new List<FizzBuzzRule>();
        public FizzBuzzRenderer()
        {
            _rules.Add((int i) => i%3 == 0 ? "Fizz" : null);
            _rules.Add((int i) => i%5 == 0 ? "Buzz" : null);
        }
        public FizzBuzzRenderer(List<FizzBuzzRule> rules)
        {
            _rules = rules;
        }
        public virtual string FizzBuzzOutput(int i)
        {
            var output = String.Empty;
            //Run each rule
            _rules.ForEach(r=>output+= r(i));
            if (string.IsNullOrEmpty(output))
            {
                output = i.ToString();
            }

            return output;
        }
    }
}
