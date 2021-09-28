using System; 

namespace Exercise3
{
    class Johann : Exercise
    {
        public int Run()
        {
            long maxNumber = 600851475143;

            int sqrt = (int)Math.Sqrt(maxNumber) + 1;

            bool[] bContainer = new bool[sqrt];

            for(int i=2; i<bContainer.Length; i++)
                if (!bContainer[i])
                    for (int j=i+i; j<bContainer.Length; j+=i)
                        bContainer[j] = true;

            for(int i=bContainer.Length-1; i>=0; i--)
                if (!bContainer[i])
                    if ((maxNumber % i) == 0)
                        return i;

            return 0;
        }
    }
}