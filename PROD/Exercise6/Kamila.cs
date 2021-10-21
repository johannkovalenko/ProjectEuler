using System; 

namespace Exercise6
{
    class Kamila : Exercise
    {
        public int Run()
        {
            double x = 100;
            double y = x + 1;
            double z = 2*x + 1; 
            double sumofsquares = (x*y*z)/6;
            double squareofsum = Math.Pow((x*y)/2,2);
            return (int)(squareofsum-sumofsquares);
        }
    }
}