using System;

namespace Exercise3
{
    public class Dawid : Exercise
    {
        public int Run()
        {
            double input = 600851475143;
            int current = (int)Math.Round(Math.Sqrt(input));
            current = (current % 2 == 1) ? current : current + 1;

            while (current>=2)
            {
                if (input % current == 0)
                    if (IsPrime(current))
                        return current;
                current -= 2;
            }

            if (input % 2 == 0)
                return 2;
            else
                return 1;
        }

        private bool IsPrime(int number)
        {
            for (int counter=2;counter<number;counter++)
                if (number % counter == 0)
                    return false;
            return true;
        }
    }
}