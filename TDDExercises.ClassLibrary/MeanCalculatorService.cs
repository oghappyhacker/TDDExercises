using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class MeanCalculatorService
    {
        public double GetMeanFromIEnumerable(IEnumerable<double> iEnumerable)
        {
            double sum = 0;
            double length = 0;
            foreach (double value in iEnumerable)
            {
                sum += value;
                length += 1;
            }
            return sum / length;
        }
    }
}
