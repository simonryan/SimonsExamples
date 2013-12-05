using System;
using System.Collections.Generic;

namespace BinarySearchIComparer
{
    public class CompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x == null) return -1;
            if (y == null) return 1;

            return String.Compare(x.Name, y.Name);
        }
    }
}
