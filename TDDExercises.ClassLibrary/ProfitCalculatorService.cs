using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class ProfitCalculatorService
    {
        public double GetProfitMargin(double revenue,double cost)
        {
            return (revenue - cost) / revenue;
        }
    }
}
