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
            return sentence.Count(letter => letter == character);
        }
        public int GetLetterCountAlt(string sentence,char character) 
        {
            int count = 0;
            foreach (char letter in sentence)
            {
                if (letter == character)
                    count++;
            }
            return count;
        }
    }
}
