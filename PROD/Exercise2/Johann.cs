namespace Exercise2
{
    class Johann : Exercise
    {
        private int sum;
        private int maxNumber;

        public int Run()
        {
            sum = 0;
            maxNumber = 4000000;
            Do(1, 1);
            return sum;    
        }

        private void Do(int previous, int current)
        {
            int newCurrent = previous + current;
            
            if (newCurrent < maxNumber)
            {
                if ((newCurrent & 1) == 0)
                    sum += newCurrent;

                Do(current, newCurrent);
            }
        }
    }
}