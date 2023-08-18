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
            return values.Sum(value => Math.Abs(value));
        }
    }
}
