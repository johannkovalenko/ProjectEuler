using System;
using System.Diagnostics;

namespace prod
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            int result = 0;

            Exercise[] exercises = {new Exercise38()};

            foreach (Exercise exercise in exercises)
            {
                stopwatch.Reset();
                stopwatch.Start();

                //for (int i=0; i<100; i++)
                    result = exercise.Run(1000);
                
                stopwatch.Stop();

                Console.WriteLine(result + "  " + stopwatch.Elapsed.TotalMilliseconds);
            }
        }
    }

    interface Exercise
    {
        int Run(int maxNumber);
    }
}
