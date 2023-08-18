using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{
    public class WordReverserService
    {
        public string ReverseWord(string word)
        {
            return string.Join("", word.Reverse());
        }
    }
}
