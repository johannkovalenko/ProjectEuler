using System.Collections.Generic;

namespace Exercise4
{
    class Krystian : Exercise
    {
        public int Run()
        {
            int lowerLimit = 100;
            int higherLimit = 999;
            int firstNumber = higherLimit;
            int secondNumber = higherLimit;
            int product = 0;
            int biggestPalindrome = 0;
            string stringProduct;
            string reversedProduct;

            while (secondNumber > lowerLimit)
            {
                while (firstNumber > lowerLimit)
                {
                    product = firstNumber * secondNumber;
                    stringProduct = product.ToString();
                    char[] myArr = stringProduct.ToCharArray();
                    Array.Reverse(myArr);
                    reversedProduct = new string(myArr);
                    if (reversedProduct == stringProduct)
                    {
                        firstNumber = 100;
                        if (product > biggestPalindrome)
                        {
                            biggestPalindrome = product;
                        }
                    }
                    else
                    {
                        firstNumber--;
                    }
                }
                firstNumber = higherLimit;
                secondNumber--;
            }
            return biggestPalindrome;
        }
    }
}