using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class Permutations2
    {
        public static void GetPermutations(String str)
        {
            Permutations("", str, 0);
        }

        private static void Permutations(String prefix, String str, int depth) 
        {
            Console.WriteLine("Depth:{0} prefix:{1} string:{2}", depth, prefix, str);
            int n = str.Length;
            if (n == 0)
            {
                Console.WriteLine(prefix);
            }
            else 
            {
                for (int i = 0; i < n; i++)
                {
                    Permutations(prefix + str[i], str.Substring(0, i) + str.Substring(i + 1), depth+1);
                }
            }
            Console.WriteLine("Returns Depth:{0} prefix:{1} string:{2}", depth, prefix, str);
}
    }
}
