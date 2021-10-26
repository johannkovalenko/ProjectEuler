using System;

namespace Exercise7
{
    public class Dawid : Exercise
    {
        public int Run()
        {
            int counter = 2;
            int number = 3;

            while (counter < 10001)
            {
                number += 2;
                if (IsPrime(number))
                    counter++;
            }

            return number;
        }

        private bool IsPrime(int number)
        {
            for (int counter=3;counter<Math.Sqrt(number)+1;counter+=2)
                if (number % counter == 0)
                    return false;
            return true;
        }
    }
}