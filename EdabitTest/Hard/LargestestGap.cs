using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Hard
{
    class LargestestGap
    {
        public static decimal LargestGap(int[] arr)
        {
            Array.Sort(arr);
            int biggestGap = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int currentGap = Math.Abs(arr[i - 1] - arr[i]);
                biggestGap = Math.Max(currentGap, biggestGap);
            }
            return biggestGap;
        }
    }
}
