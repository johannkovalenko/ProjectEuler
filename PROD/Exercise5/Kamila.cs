using System; 

namespace Exercise5
{
    class Kamila : Exercise
    {
        public int Run()
        {
            int a = 2520;

            while (a%19!=0 || a%18!=0 || a%17!=0 || a%16!=0 || a%15!=0 || a%14!=0 || a%13!=0 || a%12!=0 || a%11!=0)
                a += 20;
        
            return a;
        }
    }
}