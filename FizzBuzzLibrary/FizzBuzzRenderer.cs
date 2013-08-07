using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class FizzBuzzRenderer
    {
        public virtual string FizzBuzzOutput(int i)
        {
            var output = String.Empty;
            if (i%3 == 0)
            {
                output += "Fizz";
            }
            if (i%5 == 0)
            {
                output += "Buzz";
            }

            if (string.IsNullOrEmpty(output))
            {
                output = i.ToString();
            }

            return output;
        }
    }
}
