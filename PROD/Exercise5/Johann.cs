using System.Collections.Generic;
using System;

namespace Exercise5
{
    public class Johann : Exercise
    {
        public int Run()
        {
            var maxDict = new Dictionary<int, int>();
            int[] primes = new int[]{2, 3, 5, 7, 11, 13, 17, 19};

            for (int number=2; number<20; number++)
            {
                int quotient = number;

                foreach (int prime in primes)
                {
                    int counter = 0;

                    while (quotient % prime == 0)
                    {
                        counter++;
                        quotient /= prime;
                    }

                    if (!maxDict.ContainsKey(prime) || counter > maxDict[prime])
                        maxDict[prime] = counter;

                    if (quotient == 1)
                        break;
                }
            }

            int result = 1;

            foreach (KeyValuePair<int, int> pair in maxDict)
                result *= (int)(Math.Pow(pair.Key, pair.Value));

            return result;
        }
    }
}