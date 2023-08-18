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
            return age * 365.25;
        }
    }
}