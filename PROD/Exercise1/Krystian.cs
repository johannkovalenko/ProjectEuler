namespace Exercise1
{
    class Krystian : Exercise
    {
        public int Run()
        {
            int sum = 0;
            int smaller_number = 3;
            int bigger_number = 5;
            int i = 1;
 
            while (i * smaller_number < 1000)
            {
                sum = sum + i * smaller_number;
                i++;
            }
 
            i = 1;
            while (i * bigger_number < 1000)
            {
                sum = sum + i * bigger_number;
                i++;
            }
 
            i = 1;
            while (i * smaller_number * bigger_number < 1000)
            {
                sum = sum - i * smaller_number * bigger_number;
                i++;
            }

            return sum;
        }
    }
}