namespace prod
{
    class Exercise1 : Exercise
    {
        public int Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber + 1];

            int[] primes = {3, 5};

            foreach (int prime in primes)
                for (int current = prime; current < maxNumber; current += prime)
                    bContainer[current] = true;

            int sum = 0;

            for (int i=0; i<bContainer.Length; i++)
                if (bContainer[i])
                    sum+=i;

            return sum;
        }
    }
}