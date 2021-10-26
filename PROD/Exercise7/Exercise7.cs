using System;

namespace prod
{
    class Johann : Exercise
    {
        public int Run()
        {
            int counter = 0;
            int parameter = 0;

            bool[] bContainer = new bool[1000000];

            for(int i=2; i<bContainer.Length; i++)
                if (!bContainer[i])
                    if(++counter == parameter)
                        return i;
                    else for (int j=i+i; j<bContainer.Length; j+=i)
                        bContainer[j] = true;

            return 0;
        }
    }
}