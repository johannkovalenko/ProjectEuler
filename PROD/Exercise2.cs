namespace prod
{
    class Exercise2 : Exercise
    {
        private int sum = 0;
        private int maxNumber;

        public int Run(int maxNumber)
        {
            this.maxNumber = maxNumber;
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