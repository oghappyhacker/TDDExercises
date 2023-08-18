using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class LogicalOperationsService
    {
        public bool PerformOperation(int numberOne, int numberTwo, Func<bool, bool, bool> operation)
        {
            return operation(Convert.ToBoolean(numberOne), Convert.ToBoolean(numberTwo));
        }

        public bool And(int numberOne, int numberTwo)
        {
            return PerformOperation(numberOne, numberTwo, (a, b) => a && b);
        }

        public bool Not(int numberOne, int numberTwo)
        {
            return !PerformOperation(numberOne, numberTwo, (a, b) => a && b);
        }

        public bool Or(int numberOne, int numberTwo)
        {
            return PerformOperation(numberOne, numberTwo, (a, b) => a || b);
        }
    }
}