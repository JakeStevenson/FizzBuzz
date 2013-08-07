using System;

namespace FizzBuzzLibrary
{
    public class FizzBuzzLooper
    {
        private readonly FizzBuzzRenderer _renderer;
        public FizzBuzzLooper(FizzBuzzRenderer renderer)
        {
            _renderer = renderer;
        }
        public virtual void Loop(int start = 1, int end = 100)
        {
            if(end < start){throw new ArgumentException("End must be higher than start");}
            for (var i = start; i <= end; i++)
            {
                Console.WriteLine(_renderer.FizzBuzzOutput(i));
            }
        }

    }
}
