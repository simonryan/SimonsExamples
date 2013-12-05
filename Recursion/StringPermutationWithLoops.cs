using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class StringPermutationWithLoops
    {
        public List<string> GetPermutations(string str)
        {
            var permutations = new List<string>();
            
            if (string.IsNullOrEmpty(str)) return permutations;

            //get first
            var first = str[0];
            var remainder = str.Substring(1);

            for (var i = 0; i < remainder.Length; i++)
            {
                // add the first letter to each place in the string
                var list = new List<char>(str);
            }


                return permutations;
        }
    }
}
