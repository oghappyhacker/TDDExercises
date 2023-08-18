using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises.ClassLibrary
{ 
    public class PalindromeCheckerService
    {
        public bool IsPalindrome(string wordToCheck)
        {
            return wordToCheck.ToLower().SequenceEqual(wordToCheck.ToLower().Reverse());
        }
    }
}
