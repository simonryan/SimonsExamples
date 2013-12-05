using System;
using System.Collections.Generic;

namespace ArraysAndstrings
{
    public static class Permutations
    {
        public static List<string> GetPermutations(string s, int depth)
        {
            Console.WriteLine("Depth: {0} Permutations of {1}", depth, s);

            var permutations = new List<string>();
            if (s.Length == 0)
            {
                permutations.Add("");
                return permutations;
            }

            char first = s[0]; // get the first character
            string remainder = s.Substring(1); // remove the first character

            List<string> words = GetPermutations(remainder, depth + 1);

            foreach (string word in words)
            {
                for (int j = 0; j <= word.Length; j++)
                {
                    permutations.Add(insertCharAt(word, first, j));
                }
            }

            Console.WriteLine("Depth: {0} Returns [{1}]", depth, string.Join(", ", permutations.ToArray()));
            return permutations;
        }

        public static string insertCharAt(string word, char c, int i)
        {
            string start = word.Substring(0, i);
            string end = word.Substring(i);
            return start + c + end;
        }
    }
}
