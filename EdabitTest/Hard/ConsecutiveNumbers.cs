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
            Array.Sort(numbers);
            var noDuplicates = numbers.Distinct();
            bool boolean = false;
            for (var i = 1; i < numbers.Length + 1; i++) //numbers.length + 1 = 7
            {
                if (numbers[i-1] != (numbers[i] + 1) || numbers[i-1] != numbers[i]) boolean = true;
            }
            return !boolean;
        }
    }
}
