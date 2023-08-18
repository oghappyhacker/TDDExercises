using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class AgeToDaysService
    {
        public double AgeToDays(double age)
        {
            var ageToDays = age * 365.25;
            return ageToDays;
        }
    }
}