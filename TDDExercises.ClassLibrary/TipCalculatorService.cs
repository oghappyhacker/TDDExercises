using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class TipCalculatorService
    {
        public object CalculateTip(double total,double tipPercent)
        { return total * tipPercent; }
    }
}
