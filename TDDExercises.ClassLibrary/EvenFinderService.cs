using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class EvenFinderService
    {
        public bool IsNumberEven(int number)
        {
            bool result = false;
            if (number % 2 == 0) 
                result = true;
            return result;
        }
        public bool IsNumberOdd(int number)
        {
            bool result = false;
            if (number % 2 != 0)
                result = true;
            return result;
        }
    }
}
