using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class CalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a,int b)
        { return a - b; }
        public int Multiply(int a,int b)
        { return a * b; }
        public int Divide(int a,int b) {  return a / b; }
        public int Remainder(in int a,in int b) {  return a % b; }
    }
}
