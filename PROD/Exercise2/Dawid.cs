namespace Exercise2
{
    public class Dawid : Exercise
    {
        public int Run()
        {
            int sum = 2;
            int counter = 3;
            int current = 3;
            int previous = 2;
            int previous2 = 1;

            while (current<4000000)
            {
                if (((counter-2) % 3) == 0)
                    sum += current;

                previous2 = current;
                current += previous;
                previous = previous2;
                counter += 1;
            }

            return sum;
        }
    }
}