using System.Collections.Generic;
using System;

namespace Exercise6
{
    public class Johann : Exercise
    {
        public int Run()
        {
            double sumOfSquares = 0;
            double squareOfSum = 0;

            for (int i=1; i<=100; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
                squareOfSum += i;
            }

            squareOfSum = Math.Pow(squareOfSum, 2);

            return (int)(squareOfSum - sumOfSquares);
        }
    }
}