using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdabitTest.Hard
{
    class ConsecutiveNumbers
    {
        public static bool CanConsecutiveNumbers(int[] numbers)
        {
            var noDuplicates = numbers.Distinct().ToArray();
            Array.Sort(noDuplicates);

            bool boolean = true;
            for (var i = 0; i < numbers.Length; i++) //numbers.length = 6
            {
                var canIndexMinusOne = i != 0 ? i - 1 : i; //her må det fikses
                if (noDuplicates[canIndexMinusOne] == noDuplicates[i]-1) boolean = false;
            }
            return !boolean;
        }
    }
}
