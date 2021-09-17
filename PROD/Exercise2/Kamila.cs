using System.Collections.Generic;

namespace Exercise2
{
    class Kamila : Exercise
    {
        public int Run()
        {
            int a = 0;
            int b = 1;
            
            List<int> list = new List<int> {a, b};
            
            int i = 0;
            int sum = 0;

            while (list[i] + list[i+1] < 4000000)
            {
                list.Add(list[i] + list[i+1]); 
                i++;
            }

            foreach (int j in list)
                if (j % 2 == 0)
                    sum += j;

            return sum;
        }
    }
}