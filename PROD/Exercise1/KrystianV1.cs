namespace Exercise1
{
    class KrystianV1 : Exercise
    {
        public int Run()
        {
            int sum = 0;
            int smaller_number = 3;
            int bigger_number = 5;
            int i = 1;
 
            int[] primes = {3, 5, -15};

            int currentNumber = 0;

            foreach (int prime in primes)
            {
                while (currentNumber < 1000)
                {
                    currentNumber += prime;
                    sum = sum + currentNumber;
                    i++;
                }

                currentNumber = 0;
                i = 1;
            }

            while (i * smaller_number * bigger_number < 1000)
            {
                sum = sum - i * smaller_number * bigger_number;
                i++;
            }

            return sum;
        }
    }
}