using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EdabitTest.Medium
{
    class PositiveCountNegativeSum
    {
        public static int[] PositiveCountNegativeSumA(int[] numbers)
        {
            int count = 0;
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number > 0) count++;
                else if (number == 0);
                else sum += number;
            }
            return new[] {count, sum};
        }
    }
}
