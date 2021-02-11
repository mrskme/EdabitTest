using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EdabitTest.Easy;
using EdabitTest.Hard;
using EdabitTest.Medium;

namespace EdabitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = ConsecutiveNumbers.CanConsecutiveNumbers(new[] { 5, 1, 4, 3, 2, 8 });
            Console.WriteLine(r);
        }
    }
}
