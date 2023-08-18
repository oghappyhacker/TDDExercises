using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class MinMaxFinderService
    {
        public int[] MinMaxArrayGenerator(int[] values)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int value in values)
            {
                if (value < min)
                    min = value;
                else if (value > max)
                    max = value;
            }
            return new int[] { min, max };
        }
    }
}
