using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miscellaneous
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ReverseStringByLoop("qwerty"));
            Console.ReadKey();
        }

        private static string ReverseStringByLoop(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentOutOfRangeException(str);
            }

            var strAsArray = str.ToArray();

            string reversedStr = null;
            for (var i = strAsArray.Length - 1; i > -1; i-- )
            {
                reversedStr += strAsArray[i];
            }

            return reversedStr;
        }
    }
}
