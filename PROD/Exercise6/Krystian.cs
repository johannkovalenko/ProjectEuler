using System.Collections.Generic;
using System;

namespace Exercise6
{
    class Krystian : Exercise
    {
        public int Run()
        {
            int n = 100;
            int sumOfSquares = 0;
            int squareSum = 0;
            for (int i = 1; i <= n; i++)
            {
                sumOfSquares += i * i;
                squareSum += i;
            }
            int difference = squareSum * squareSum - sumOfSquares;
            return difference;

        }
    }
}