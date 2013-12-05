using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class ReverseString
    {
        public string Reverse1(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentOutOfRangeException();

            var str = s.ToCharArray();
            
            var reversed = str.Reverse().ToArray();
            
            return new string(reversed);
        }

        public string Reverse2(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) throw new ArgumentOutOfRangeException();

            var sb = new StringBuilder();
            var str = s.ToCharArray();

            for(var i = str.Length; i >= 0; i--)
            {
	            sb.Append(str[i]);
            }
            
            return sb.ToString();
        }
    }
}
