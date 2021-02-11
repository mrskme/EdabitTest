using System;
using System.Collections.Generic;
using System.Text;

namespace EdabitTest.Easy
{
    class ShuffleTheName
    {
        public string ReturnSplitName(string name) => Splitter(name, 0) + " " + Splitter(name, 1);

        public string Splitter(string name, int i)
        {
            var partOfName = name.Split(" ");
            return partOfName[i];
        }
    }
}
