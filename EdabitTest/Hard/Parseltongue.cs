using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Hard
{
    class Parseltongue
    {
        public static bool IsParseltongue(string sentence)
        {
            var words = sentence.ToLower().Split(" ");
            foreach (var word in words)
            {
                word.Contains("ss");
            }
            return false;
        }
    }
}
