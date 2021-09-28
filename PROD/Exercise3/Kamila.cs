using System; 

namespace Exercise3
{
    class Kamila : Exercise
    {
        public int Run()
        {
            long number1 = 600851475143;
            int i = 3;

            while (number1 > 1)
                if (number1 % i != 0)
                    i += 2; 
                else
                    number1 /= i;

            return i;
        }
    }
}