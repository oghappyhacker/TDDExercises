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
            if (num % 2 != 0)
                return true; return false;
        }
        public bool IsNumberEven(int num)
        {
            if (num % 2 == 0) 
                return true; return false;
        }
    }
}
