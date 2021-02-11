using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdabitTest.Medium
{
    class ArrayOfMultiples
    {
        public static int[] ArrayofMultiples(int num, int length)
        {
            var arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = num * (i + 1);
            }
            return arr;
        }
    }
}
