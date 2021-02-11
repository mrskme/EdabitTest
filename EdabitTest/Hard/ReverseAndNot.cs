using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Hard
{
    class ReverseAndNot
    {
        public static string reverseAndNotMethod(string word)
        {
            var newWord = string.Empty;
            for (int i = 1; i < word.Length + 1; i++)
            {
                newWord += word[^i];
            }

            newWord += word;
            return newWord;
        }
    }
}
