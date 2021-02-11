using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Medium
{
    class ReturnMiddleCharacter
    {
        public static string ReturnMiddle(string word)
        {
            var length = word.Length;
            var isEven = length % 2 == 0;
            var MiddleIndex = length / 2 - 1;
            if (isEven) return $"{word[MiddleIndex]}{word[MiddleIndex + 1]}";
            return word[MiddleIndex].ToString();
        }
    }
}
