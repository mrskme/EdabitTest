using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Hard
{
    class ReverseTheOddLengthSentence
    {
        public static string ReverseTheOdd(string word)
        {
            string reversedWord = string.Empty;
            if (word.Length % 2 == 1)
            {
                for (int i = 1; i < word.Length + 1; i++)
                {
                    reversedWord += word[^i];
                }
            }
            else reversedWord = word;
             
            return reversedWord;
        }
    }
}
