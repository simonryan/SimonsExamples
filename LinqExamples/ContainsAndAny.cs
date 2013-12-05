using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExamples
{
    public static class ContainsAndAny
    {
        static string[] famousQuotes = {
                                        "Advertising is legalized lying",
                                        "Advertising is the greatest art form of the twentieth centrury"

                                    };

        static string quote = "Advertising is the greatest art form of the twentieth centrury";

        public static void StartsWith()
        {
            var result = famousQuotes.Any(s => s.StartsWith("Advertising"));

        }

        public static void Contains()
        {
            var result = famousQuotes.SelectMany(s => s.Split(' ')).Contains("Advertising");
        }

        public static void Reverse()
        {
            var words = quote.ToArray();
            var result = words.Reverse();
        }
    }
}
