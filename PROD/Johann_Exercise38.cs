using System;
using System.Collections.Generic;

namespace prod
{
    class Johann_Exercise38 : Exercise
    {
        private bool[] sieve = new bool[100000];
        private Dictionary<int, string> potentialNumbers = new Dictionary<int, string>();

        public int Run(int parameter)
        {
            Step1_SieveOut();
            Step2();
            return Step3();
        }

        private int Step3()
        {
            int max = 0;

            foreach (KeyValuePair<int, string> pair in potentialNumbers)
            {               
                
                int[] check = new int[10];
                foreach (char digit in pair.Value)
                    check[digit - '0']++;

                bool repeats = false;

                foreach (int rep in check)
                    if (rep > 1)
                    {
                        repeats = true;
                        break;
                    }

                if (!repeats)
                {
                    int parsed = int.Parse(pair.Value);

                    if (parsed > max)
                        max = parsed;
                }
            }

            return max;
        }

        private void Step2()
        {
            int testCount = 0;
            int[] factors = {2, 3, 4, 5};

            for (int number=0; number<sieve.Length; number++)
            {
                if (!sieve[number])
                {
                    string strNumber = number.ToString(); 

                    foreach (int factor in factors)
                    {
                        int product = number * factor;

                        if (product < sieve.Length && !sieve[product])
                        {
                            strNumber += product.ToString();
                            int length = strNumber.Length;
                            if (length == 9)
                                potentialNumbers.Add(number, strNumber);
                            else if (length > 9)
                                break;
                        }
                        else break;
                    }
                }
            }

            Console.WriteLine(testCount);
        }

        private void Step1_SieveOut()
        {
            int number = 0;

            for (int i=0; i<10; i++)
                for (int j=0; j<10; j++)
                    for (int k=0; k<10; k++)
                        for (int l=0; l<10; l++)
                            for (int m=0; m<10; m++)
                            {
                                if (number >= 10000 && (i == 0 || j == 0 || k == 0 || l == 0 || m==0))
                                    sieve[number] = true;
                                else if (number >= 1000 && (j == 0 || k == 0 || l == 0 || m==0))
                                    sieve[number] = true;
                                else if (number >= 100 && (k == 0 || l == 0 || m==0))
                                    sieve[number] = true;
                                else if (number >= 10 && (l == 0 || m==0))
                                    sieve[number] = true;
                                else if (number >= 0 && (m==0))
                                    sieve[number] = true;
                                else
                                {
                                    int[] check = new int[10];
                                    check[i]++;
                                    check[j]++;
                                    check[k]++;
                                    check[l]++;
                                    check[m]++;

                                    for (int rep = 1; rep<check.Length; rep++)
                                        if (check[rep] > 1)
                                            sieve[number] = true;

                                    //if (!sieve[number]) { Console.WriteLine(number); Console.ReadLine();}
                                }
                                number++;
                            }
        }
    }
}