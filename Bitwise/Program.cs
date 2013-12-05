using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = 3;
            int count = 0;
            while (num != 0)
            {
                num = num & num - 1;
                count++;
            }
            Console.WriteLine(count);
            Console.Read();
        }
    }
}
