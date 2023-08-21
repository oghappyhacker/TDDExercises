using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class LetterMultiplierService
    {
        public string LetterMultiple(char letter,int value)
        {
            return new string(letter,value);
        }
        public string LetterMultipleAlt(char letter,int value)
        {
            var wordOfALetter = "";
            for(var i = 0;i < value;i++)
                wordOfALetter += letter;
            return wordOfALetter;
        }
    }
}
