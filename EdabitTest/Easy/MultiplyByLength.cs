using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdabitTest.Easy
{
    class MultiplyByLength
    {
        public static int[] Multiply(int[] arr)
        {
            var multiplierArr = new int[arr.Length];

                 return new[] {arr.Aggregate(0, (seed, i) => seed + i * arr.Length)};
        }
    }
}
