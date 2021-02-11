using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EdabitTest.Medium
{
    class ReverseTheCase
    {
        public static string ReverseCase(string word)
        {
            var reversedCaseWord = string.Empty;
            foreach (var letter in word)
            {
                if (char.IsUpper(letter)) reversedCaseWord += char.ToLower(letter);
                else if (char.IsLower(letter)) reversedCaseWord += char.ToUpper(letter);
                else if (letter.Equals(' ')) reversedCaseWord += ' ';
            }
            return reversedCaseWord;
        }
        public static string ReverseCaseRefactorized(string word) 
            => string.Concat(word.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c));
    }
}
