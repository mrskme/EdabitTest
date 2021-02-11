using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Medium
{
    class EqualityCheck
    {
        public static bool CheckEquality(object a, object b)
            => a.GetType().Equals(b.GetType()) && a.Equals(b);
    }
}
