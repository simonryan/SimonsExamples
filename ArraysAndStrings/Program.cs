using System;
using ArraysAndstrings;

namespace ArraysAndStrings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //StringContainsUniqueChars.Run();
            //StringContainsUniqueCharsV2.Run();

            //var result = RemoveDuplicateChars.RemoveDuplicates1("aa");
            //Console.WriteLine(result);

            // sort and compare
            //var result = Anagrams.IsAnagram1("ewerty", "ytrewq");
            // count the characters
            //var result = Anagrams.IsAnagram2("qwertyy", "ytrewyq");
            //Console.WriteLine("Strings {0} anagrams", result ? "are" : "are not");

            //RotateMatrix.RotateSquareMatrix();
            //RotateMatrix.RotateRectangularMatrix();

            Permutations.GetPermutations("abc", 0);

            MatrixZeros.ReplaceValues();

            Console.ReadKey();
        }
    }
}

