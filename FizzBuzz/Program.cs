using System;
using FizzBuzzLibrary;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var looper = new FizzBuzzLibrary.FizzBuzzLooper(new FizzBuzzRenderer());
            looper.Loop(1,100);
            Console.ReadLine();
        }
    }
}
