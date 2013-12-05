using System;
using System.Linq;

namespace ArraysAndStrings
{
    public static class StringContainsUniqueChars
    {
        public static void Run()
        {
            var str = Console.ReadLine();

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String cannot be empty");
                return;
            }

            var strToParse = str.ToArray();
            var charsInString = new char[256]; // ascii so 256 different chars

            charsInString[0] = strToParse[0];
            var index = 0;

            for (var i = 1; i < strToParse.Length; i++)
            {
                if (CharInArray(charsInString, strToParse[i]))
                {
                    Console.WriteLine("Not unique chars");
                    Console.ReadKey();
                    return;
                }
                charsInString[++index] = strToParse[i];
            }
            Console.WriteLine("String contains unique chars");
            Console.ReadKey();
        }

        private static bool CharInArray(char[] existingChars, char charToFind)
        {
            foreach (char c in existingChars)
            {
                if (c == '\0') break;
                if (c == charToFind)
                {
                    return true;
                }
            }
            return false;

            // alternatively as LINQ...
            // return existingChars.TakeWhile(c => c != '\0').Any(c => c == charToFind);
        }
    }
}
