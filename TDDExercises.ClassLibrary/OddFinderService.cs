using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class OddFinderService
    {
        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }
        public bool IsNumberEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
