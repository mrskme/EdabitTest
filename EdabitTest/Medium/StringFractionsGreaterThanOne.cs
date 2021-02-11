using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdabitTest.Medium
{
    class StringFractionsGreaterThanOne
    {
        public static bool GreaterThanOne(string fraction)
        {
            var numbers = fraction.Split("/").Select(n => int.Parse(n)).ToArray();
            return numbers[0] > numbers[1];
        } 
    }
}
