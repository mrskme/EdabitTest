using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Hard
{
    class SmoothSentence
    {
        public static bool IsSmoothSentence(string sentence)
        {
            var words = sentence.ToLower().Split(" ");
            var boolean = true;
            for (int i = 1; i < words.Length - 1; i++)
            {
                if (!words[i-1][^1].Equals(words[i][0])) boolean = false;
            }
            return boolean;
        }
    }
}
