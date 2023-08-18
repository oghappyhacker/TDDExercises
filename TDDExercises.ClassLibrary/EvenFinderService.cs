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
            return number % 2 == 0;
        }
        public bool IsNumberOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
