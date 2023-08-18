using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class LetterCounterService
    {
        public int GetLetterCount(string sentence,char character)
        {
            return sentence.Count(c => c == character);
        }
    }
}
