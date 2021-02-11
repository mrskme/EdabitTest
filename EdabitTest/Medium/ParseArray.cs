using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdabitTest.Medium
{
    class ParseArray
    {
        public static string[] parseTheArray(object[] arr) => arr.Select(o => o.ToString()).ToArray();
    }
}
