using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace prod
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            int result = 0;

            Dictionary<string, Exercise> algorithms = FactoryMethod(args);

            var sb = new StringBuilder();

            foreach (KeyValuePair<string, Exercise> pair in algorithms)
            {
                stopwatch.Reset();
                stopwatch.Start();

                for (int i=0; i<100; i++)
                    result = pair.Value.Run();
                
                stopwatch.Stop();

                sb.Append(pair.Key + "\t" + result + "  " + stopwatch.Elapsed.TotalMilliseconds + "\r\n");
            }

            Console.WriteLine(sb.ToString());
        }

        private static Dictionary<string, Exercise> FactoryMethod(string[] args)
        {
            if (args.Length == 0)
                return FactoryExercise1();
            else switch (args[0])
            {
                case "1":
                    return FactoryExercise1();
                default:
                    return FactoryExercise1();
            }
        }

        private static Dictionary<string, Exercise> FactoryExercise1()
        {
            return new Dictionary<string, Exercise>
            {
                { "Johann   ", new Exercise1.Johann() },
                { "Piotr    ", new Exercise1.Piotr() },
                { "Krystian ", new Exercise1.Krystian() },
                { "Johann1  ", new Exercise1.Johann() },
                { "Piotr1   ", new Exercise1.Piotr() },
                { "Krystian1", new Exercise1.Krystian() },
            };
        }
    }
}
