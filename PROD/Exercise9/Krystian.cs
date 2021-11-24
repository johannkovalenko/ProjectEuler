using System;

namespace Exercise9
{
    public class Krystian : Exercise
    {
        public int Run()
        {
            private static int gcd(int m, int n)
            {
                while (m != n)
                {
                    if (m > n)
                    {
                        m = m - n;
                    }
                    else
                    {
                        n = n - m;
                    }
                }
                return m;
            }

            int a = 0, b = 0, c = 0;
            int m = 2;
            bool found = false;
            int sum = 1000;
            while (found == false)
            {
                for (int n = 1; n < m; n++)
                {
                    if (gcd(m, n) == 1 && (m + n) % 2 != 0 && found == false)
                    {
                        a = m * m - n * n;
                        b = 2 * m * n;
                        c = m * m + n * n;
                        for (int d = 1; d * (a + b + c) <= sum; d++)
                        {
                            if (d * (a + b + c) == 1000)
                            {
                                a = d * a;
                                b = d * b;
                                c = d * c;
                                found = true;
                            }
                        }
                    }

                }
                m++;
            }

            return a * b * c;
        }
    }
}