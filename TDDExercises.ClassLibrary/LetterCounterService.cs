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
            int lenght = sentence.Count(c => c == character);
            return lenght;
        }
    }
}
