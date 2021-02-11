using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Medium
{
    class FindTheBomb
    {
        public static string FindBomb(string sentence) 
            => sentence.Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
    }
}
