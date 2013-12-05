using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class StringContainsUniqueCharsV2
    {
        public static void Run()
        {
            var str = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("No string given");
                return;
            }
            
            var chars = new bool[256];
            
            foreach (int ascii in str)
            {
                if (chars[ascii])
                {
                    Console.WriteLine("Duplicate char found");
                    return;
                }
                chars[ascii] = true;
            }
            Console.WriteLine("String contains unique chars");
        }
    }
}
