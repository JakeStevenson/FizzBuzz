using System;
using System.Collections.Generic;
using FizzBuzzLibrary;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Standard FizzBuzz:");
            Console.WriteLine(new string('=',40));
            var looper = new FizzBuzzLooper(new FizzBuzzRenderer());
            looper.Loop();
            Console.ReadLine();


            //Allow custom rules to be added as anonymous functions.
            Console.WriteLine("Custom FizzBuzz:");
            Console.WriteLine(new string('=',40));
            var rules = new List<FizzBuzzRule>()
                            {
                                (i) => i%10 == 0 ? "ZOOOM" : null
                            };
            looper = new FizzBuzzLooper(new FizzBuzzRenderer(rules));
            looper.Loop(100,200);
            Console.ReadLine();
        }
    }
}
