using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest
{
    public class MonthToString
    {
        public enum Months
        {
            Januar = 1,
            Februar,
            March,
            April,
            Mai,
            Juni,
            Juli,
            August,
            September,
            Oktober,
            November,
            Desember
        }
        public List<Months> FromIntToMonth(params int[] months)
        {
            List<Months> monthsArrayAsEnum = new List<Months>();
            foreach (var month in months)
            {
                monthsArrayAsEnum.Add((Months)month);
            }
            return monthsArrayAsEnum;
        }
    }
}
