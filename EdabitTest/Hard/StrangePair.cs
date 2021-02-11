using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Hard
{
    class StrangePair
    {
        public static bool IsStrangePair(string str1, string str2)
            => str1[0].Equals(str2[^1]) && str1[^1].Equals(str2[0]);
    }
}
