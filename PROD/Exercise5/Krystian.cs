using System.Collections.Generic;
using System;

namespace Exercise5
{
    class Krystian : Exercise
    {
        public int Run()
        {
            int[] factors = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int examinedNumber = 2520;
            int increment = 2520;
            int reminder;
            int i;
            bool multipleFound = false;

            while (multipleFound == false)
            {
                i = 0;
                reminder = 0;
                while (reminder == 0 && i < 9)
                {
                    reminder = examinedNumber % factors[i];
                    i++;
                    if (i == 9 && reminder == 0)
                    {
                        multipleFound = true;
                    }
                }
                if (multipleFound == false)
                {
                    examinedNumber = examinedNumber + increment;
                }
            }
            return examinedNumber;

        }
    }
}