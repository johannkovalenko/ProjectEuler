using System.Collections.Generic;

namespace Exercise2
{
    class Krystian : Exercise
    {
        public int Run()
        {
            int limit = 4000000;
            int sum = 2;
            int[] sequence = { 1, 2 };
            int new_term;
            while (sequence[1] < limit)
            {
                new_term = sequence[0] + sequence[1];
                if (new_term % 2 == 0)
                {
                    sum = sum + new_term;        
                }
                sequence[0] = sequence[1];
                sequence[1] = new_term;
            }
            return sum;
        }
    }
}