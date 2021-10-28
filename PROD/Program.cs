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

                sb.Append(pair.Key + "\t" + result + "  " + stopwatch.Elapsed.TotalMilliseconds + " ms\r\n");
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
                case "2":
                    return FactoryExercise2();
                case "3":
                    return FactoryExercise3();
                case "4":
                    return FactoryExercise4();
                case "5":
                    return FactoryExercise5();
                case "6":
                    return FactoryExercise6();
                case "7":
                    return FactoryExercise7();
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
                { "Krystian1", new Exercise1.Krystian() }
            };
        }

        private static Dictionary<string, Exercise> FactoryExercise2()
        {
            return new Dictionary<string, Exercise>
            {
                { "Johann   ", new Exercise2.Johann() },
                { "Kamila   ", new Exercise2.Kamila() },
                { "Krystian ", new Exercise2.Krystian() },
                { "Dawid    ", new Exercise2.Dawid() },
                { "Johann1  ", new Exercise2.Johann() },
                { "Kamila1  ", new Exercise2.Kamila() }, 
                { "Krystian1", new Exercise2.Krystian() },
                { "Dawid1    ", new Exercise2.Dawid() }
            };
        }

        private static Dictionary<string, Exercise> FactoryExercise3()
        {
            return new Dictionary<string, Exercise>
            {
                { "Johann   ", new Exercise3.Johann() },
                { "Kamila   ", new Exercise3.Kamila() },
                { "Krystian ", new Exercise3.Krystian() },
                { "Dawid    ", new Exercise3.Dawid() },
                { "Johann1  ", new Exercise3.Johann() },
                { "Kamila1  ", new Exercise3.Kamila() },
                { "Krystian1", new Exercise3.Krystian() },
                { "Dawid1   ", new Exercise3.Dawid() }
            };
        }

        private static Dictionary<string, Exercise> FactoryExercise4()
        {
            return new Dictionary<string, Exercise>
            {
                { "DawidEvo3  ", new Exercise4.Dawid_Evo3() },
                { "JohannEvo1 ", new Exercise4.Johann_Evo1() },
                { "Krystian   ", new Exercise4.Krystian() },
                { "Dawid1Evo3 ", new Exercise4.Dawid_Evo3() },
                { "Johann1Evo1", new Exercise4.Johann_Evo1() },
                { "Krystian1  ", new Exercise4.Krystian() }
            };
        }

        private static Dictionary<string, Exercise> FactoryExercise5()
        {
            return new Dictionary<string, Exercise>
            {
                { "Johann     ", new Exercise5.Johann() },
                { "Krystian   ", new Exercise5.Krystian() },
                { "Kamila     ", new Exercise5.Kamila_Evo1() },
                { "Johann1    ", new Exercise5.Johann() },
                { "Krystian1  ", new Exercise5.Krystian() },
                { "Kamila1    ", new Exercise5.Kamila_Evo1() },
            };
        }

        private static Dictionary<string, Exercise> FactoryExercise6()
        {
            return new Dictionary<string, Exercise>
            {
                { "Johann     ", new Exercise6.Johann() },
                { "Krystian   ", new Exercise6.Krystian() },
                { "Kamila     ", new Exercise6.Kamila() },
                { "Dawid      ", new Exercise6.Dawid() },
                { "Johann1    ", new Exercise6.Johann() },
                { "Krystian1  ", new Exercise6.Krystian() },
                { "Kamila1    ", new Exercise6.Kamila() },
                { "Dawid1     ", new Exercise6.Dawid() }
            };
        }

        private static Dictionary<string, Exercise> FactoryExercise7()
        {
            return new Dictionary<string, Exercise>
            {
                { "Johann     ", new Exercise7.Johann() },
                // { "Krystian   ", new Exercise6.Krystian() },
                // { "Kamila     ", new Exercise6.Kamila() },
                // { "Dawid      ", new Exercise6.Dawid() },
                { "Johann1    ", new Exercise7.Johann() }
                // { "Krystian1  ", new Exercise6.Krystian() },
                // { "Kamila1    ", new Exercise6.Kamila() },
                // { "Dawid1     ", new Exercise6.Dawid() }
            };
        }
    }
}
