namespace prod
{
    class Exercise1_Piotr_Evo1 : Exercise
    {
        public int Run(int maxNumber)
        {
            int answer = 0;
            int n = 0;
            int m1 = 0;

            int invertedMaxNumber = maxNumber *-1;
            
            foreach (int prime in new int[] {3, 5, -15})
            {
                m1 = 0;
                n=1;
                
                while (m1 < maxNumber && m1 > invertedMaxNumber)
                {
                    m1 = n*prime;
                    n++;

                    if (m1 < maxNumber) 
                    {
                        answer += m1;   
                    }
                }
            }

            return answer;
        }
    }

    class Exercise1_Piotr : Exercise
    {
        public int Run(int maxNumber)
        {
            int answer = 0;

            //step 1
            int m1 = 0;
            int n=1;
            
            while (m1 < maxNumber)
            {
                m1 = n*3;
                n++;

                if (m1 < maxNumber) 
                {
                    answer += m1;   
                }
            }

            //Modulo:
            //    15 % 5 = 0
            //    16 % 5 = 1

            //step 2
            int m2 = 0;
            n = 1;

            while (m2 < maxNumber)
            {
                m2 = n*5;
                n++;

                if (m2 < maxNumber)
                {
                    answer += m2;
                }
            }

            //step 3
            int m3 = 0;
            n = 1;

            while (m3 < 1000)
            {
                m3 = n*15;
                n++;

                if (m3 < 1000)
                {
                    answer -= m3;
                }
            }

            return answer;
        }
    }
}