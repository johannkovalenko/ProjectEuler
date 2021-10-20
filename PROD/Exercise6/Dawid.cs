using System;

namespace Exercise6
{
    public class Dawid : Exercise
    {
        public int Run()
        {
            int last = 100;

            int sum = (last * (last + 1))/2;
            int squares = (last * (last + 1) * (2 * last + 1))/6;

            return (int)Math.Pow(sum,2)-squares;
        }
    }
}