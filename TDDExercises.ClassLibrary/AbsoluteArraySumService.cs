using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class AbsoluteArraySumService
    {
        public int AbsoluteSummation(int[] values)
        {
            int tol = 0;
            foreach (int value in values)
            {
                tol += Math.Abs(value);
            }
            return tol;
        }
    }
}
