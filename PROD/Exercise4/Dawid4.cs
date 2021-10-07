using System;

namespace Exercise4
{
    public class Dawid : Exercise
    {
        public int Run()
        {
            int first;
            int second;
            int product;
            int currentHighest = 0;

            for (first = 999; first > 99; first--)
            {
                for (second = 999; second > 99; second--)
                {
                    product = first * second;
                    if (product > currentHighest)
                        if (IsPalindrome(product))
                            currentHighest = product;
                }
            }
            return currentHighest;
        }

        private bool IsPalindrome(int number)
        {
            if (number >= 100000)
                if (Math.Floor(number/Math.Pow(10,5)) == number % 10)
                    if (Math.Floor(number/Math.Pow(10,4)) % 10 == Math.Floor(number/Math.Pow(10,1)) % 10)
                        if (Math.Floor(number/Math.Pow(10,3)) % 10 == Math.Floor(number/Math.Pow(10,2)) % 10)
                            return true;
            else if (number >= 10000)
                if (Math.Floor(number/Math.Pow(10,4)) == number % 10)
                    if (Math.Floor(number/Math.Pow(10,3)) % 10 == Math.Floor(number/Math.Pow(10,1)) % 10)
                        return true;
            else if (number >= 1000)
                if (Math.Floor(number/Math.Pow(10,3)) == number % 10)
                    if (Math.Floor(number/Math.Pow(10,2)) % 10 == Math.Floor(number/Math.Pow(10,1)) % 10)
                        return true;
            return false;
        }
    }

    public class Dawid_Evo2 : Exercise
    {
        public int Run()
        {
            int first;
            int second;
            int product;
            int currentHighest = 0;

            for (first = 999; first > 99; first--)
            {
                for (second = 999; second > 99; second--)
                {
                    product = first * second;
                    if (product > currentHighest)
                        if (IsPalindrome(product))
                            currentHighest = product;
                }
            }
            return currentHighest;
        }

        private bool IsPalindrome(int number)
        {
            if (number >= 100000)
                if ((int)(number/Math.Pow(10,5)) == number % 10)
                    if ((int)(number/Math.Pow(10,4)) % 10 == (int)(number/Math.Pow(10,1)) % 10)
                        if ((int)(number/Math.Pow(10,3)) % 10 == (int)(number/Math.Pow(10,2)) % 10)
                            return true;
            else if (number >= 10000)
                if ((int)(number/Math.Pow(10,4)) == number % 10)
                    if ((int)(number/Math.Pow(10,3)) % 10 == (int)(number/Math.Pow(10,1)) % 10)
                        return true;
            else if (number >= 1000)
                if ((int)(number/Math.Pow(10,3)) == number % 10)
                    if ((int)(number/Math.Pow(10,2)) % 10 == (int)(number/Math.Pow(10,1)) % 10)
                        return true;
            return false;
        }
    }
    
    public class Dawid_Evo3 : Exercise
    {
        public int Run()
        {
            int first;
            int second;
            int product;
            int currentHighest = 0;

            for (first = 999; first > 99; first--)
            {
                for (second = 999; second > 99; second--)
                {
                    product = first * second;
                    if (product > currentHighest)
                        if (IsPalindrome(product))
                            currentHighest = product;
                }
            }
            return currentHighest;
        }

        private bool IsPalindrome(int number)
        {
            if (number >= 100000)
                if ((number/100000) == number % 10)
                    if ((number/10000) % 10 == (number/10) % 10)
                        if ((number/1000) % 10 == (number/100) % 10)
                            return true;
            else if (number >= 10000)
                if ((number/10000) == number % 10)
                    if ((number/1000) % 10 == (number/10) % 10)
                        return true;
            return false;
        }
    }
}
