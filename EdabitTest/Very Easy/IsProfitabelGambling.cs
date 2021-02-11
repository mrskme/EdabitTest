using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Very_Easy
{
    class IsProfitabelGambling
    {
        public static bool ProfitableGamble(double prob, int prize, double pay) => prob * prize > pay;
    }
}
