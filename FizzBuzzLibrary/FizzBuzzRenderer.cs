using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary.Rules;

namespace FizzBuzzLibrary
{
    public class FizzBuzzRenderer
    {
        private readonly IEnumerable<IRule> _rules;
        public FizzBuzzRenderer()
        {
            _rules = new IRule[]{new FizzRule(), new BuzzRule()};
        }
        public FizzBuzzRenderer(IEnumerable<IRule> rules)
        {
            _rules = rules.OrderBy(r => r.Number);
        }
        public virtual string FizzBuzzOutput(int i)
        {
            var output = String.Empty;
            foreach (var rule in _rules)
            {
                try
                {
                    output += rule.ProcessRule(i);
                }
                catch (Exception ex)
                {
                    //I don't want a bad rule to stop everything.
                    //Normally I'd do this with a logging framework, but Console because it's homework
                    Console.WriteLine(string.Format("Unable to run rule {0} on number {1}.", rule.GetType().Name, i));
                }
            }
            if (string.IsNullOrEmpty(output))
            {
                output = i.ToString();
            }
            return output;
        }
    }
}
