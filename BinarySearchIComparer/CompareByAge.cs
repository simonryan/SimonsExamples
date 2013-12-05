using System;
using System.Collections.Generic;

namespace BinarySearchIComparer
{
    public class CompareByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age > y.Age) return -1;
            if (y.Age > x.Age) return 1;

            return 0;
        }
    }
}
