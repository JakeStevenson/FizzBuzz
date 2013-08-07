using System;
using FizzBuzz.Rules;
using FizzBuzzLibrary;
using FizzBuzzLibrary.Rules;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Standard FizzBuzz Rules:");
            Console.WriteLine(new string('=', 80));
            StandardWay();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("With Injected Zoom Rule and Different Numbers:");
            Console.WriteLine(new string('=', 80));
            WithInjectedRule();
            Console.ReadLine();
        }

        static void StandardWay()
        {
            var looper = new FizzBuzzLibrary.FizzBuzzLooper(new FizzBuzzRenderer());
            looper.Loop();
        }

        static void WithInjectedRule()
        {
            //I'd usually let an IOC container do this.
            var rules = new IRule[]
                            {
                                new FizzRule(),
                                new BuzzRule(),
                                new ZoomRule()
                            };
            var looper = new FizzBuzzLooper(new FizzBuzzRenderer(rules));
            looper.Loop(100,200);
        }
    }
}
