using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class PinValidatorService
    {
        public bool ValidatePin(int pin,int correctPin)
        {
            if(pin == correctPin) return true; return false;
        }
    }
}
