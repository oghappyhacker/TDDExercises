using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class LogicalOperationsService
    {
        public bool And(int numberOne,int numberTwo)
        {
            var convert = Convert.ToBoolean(numberOne) && Convert.ToBoolean(numberTwo);
            return convert;
        }
        public bool Not(int numberOne,int numberTwo)
        {
            var convert = Convert.ToBoolean(numberOne) && Convert.ToBoolean(numberTwo);
            return !convert;
        }
        public bool Or(int numberOne,int numberTwo)
        {
            var converted = Convert.ToBoolean(numberOne) || Convert.ToBoolean(numberTwo);
            return converted;
        }
    }
}
