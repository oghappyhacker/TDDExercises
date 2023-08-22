using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class NumberCountService
    {
        public int Count(int numberToCount)
        {
            return numberToCount;
        }
        public int CountAlt(int numberToCount)
        {
            int holdNumber = 0;
            for (int i = 1;i <= numberToCount;i++)
                holdNumber++;
            return holdNumber;
        }
    }
}
