using System.Collections.Generic;

namespace Exercise3
{
    class Krystian : Exercise
    {
        public int Run()
        {
            long StudiedNumber = 600851475143; // Studied number cannot be 1 as factorization cannot be done
            long Prime = 2;
            while (StudiedNumber != 1)
            {
                if (StudiedNumber % Prime == 0)
                {
                    StudiedNumber = StudiedNumber / Prime;
                }
                else
                {
                    Prime++;
                }
            }
            return Prime;
        }
    }
}