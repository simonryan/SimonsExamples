using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class StringPermutation
    {
        public List<String> GetPerms(String s)
        {
            var permutations = new List<String>();
            if (s == null)
            {
                // error case
                return null;
            }
            if (s.Length == 0)
            {
                // base case
                permutations.Add("");
                return permutations;
            }

            char first = s[0]; // get the first character
            String remainder = s.Substring(1); // remove the first character
            List<String> words = GetPerms(remainder);
            foreach (String word in words)
            {
                for (int j = 0; j <= word.Length; j++)
                {
                    permutations.Add(InsertCharAt(word, first, j));
                }
            }
            return permutations;
        }

        public static String InsertCharAt(String word, char c, int i)
        {
            String start = word.Substring(0, i);
            String end = word.Substring(i);
            return start + c + end;
        }
    }
}
