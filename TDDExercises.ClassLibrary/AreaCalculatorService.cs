using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class AreaCalculatorService
    {
        public double GetAreaOfTriangle(double tBase, double tHeight)
        {
            return (tBase * tHeight)/2;
        }
    }
}
