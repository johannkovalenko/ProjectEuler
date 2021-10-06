namespace Exercise4
{
    public class Johann : Exercise
    {
        public int Run()
        {
            int max = 0;

            for (int i=999; i>99; i--)
                for (int j=999; j>99; j--)
                {
                    int product = i * j;

                    if (product > max && IsPalindrome(product))
                        max = product; 
                }

            return max;
        }

        private bool IsPalindrome(int product)
        {
            string productStr = product.ToString();

            int halfLength = productStr.Length / 2;

            for (int i=0; i<halfLength; i++)
            {
                char left   = productStr[i];
                char right  = productStr[productStr.Length - 1 - i];

                if (left != right)
                    return false;
            }

            return true;
        }
    }
}