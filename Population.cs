using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0 || percent <= 0 || visitors <= 0 || currentPopulation <= 0)
                throw new ArgumentOutOfRangeException();

            double n1 = initialPopulation;
            int years = 0;

            while (n1 < currentPopulation)
            {
                n1 = n1 + (n1 * percent * 0.01) + visitors;
                years++;

            }
            return years;
        }
    }
}