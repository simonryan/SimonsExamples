using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extension;

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[]
                                             {"Norwich", "London", "Luton", "Kent", "Birmingham", "Bristol", "Ipswich"};

            IEnumerable<string> results = cities.StartsWith("L");

            foreach(var city in results)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}

namespace Extension
{
    public static class FilterExtensions
    {
        public static IEnumerable<string> StartsWith(this IEnumerable<string> input, string startLetter)
        {
            foreach(var s in input)
            {
                if (s.StartsWith(startLetter))
                {
                    yield return s;
                }
            }
        }
    }
}
