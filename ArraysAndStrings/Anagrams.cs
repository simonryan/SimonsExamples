using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class Anagrams
    {
        // Create arrays from string, then sort, then make string, compare sorted strings
        public static bool IsAnagram1(string a, string b)
        {
            if (string.IsNullOrWhiteSpace(a) && string.IsNullOrWhiteSpace(b))
            {
                throw new ArgumentOutOfRangeException();
            }

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return false;

            if (a.Length != b.Length) return false;

            var arrayA = a.ToCharArray();
            var arrayB = b.ToCharArray();

            Array.Sort(arrayA);
            Array.Sort(arrayB);

            var sortedA = string.Join("", arrayA);
            var sortedB = string.Join("", arrayB);

            return sortedA.CompareTo(sortedB) == 0;
        }

        public static bool IsAnagram2(string a, string b)
        {
            var charCountA = new int[256];
            var charCountB = new int[256];

            foreach(char c in a)
            {
                charCountA[c]++;
            }

            foreach(char c in b)
            {
                charCountB[c]++;
            }

            for (var i = 0; i < charCountA.Length; i++)
            {
                if (charCountA[i] != charCountB[i]) return false;
            }
            return true;
        }
    }
}
