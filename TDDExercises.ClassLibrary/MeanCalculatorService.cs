﻿using System;
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
            return iEnumerable.Sum() / iEnumerable.Count();
        }
    }
}
