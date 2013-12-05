
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quantifiers();
            //Projection();
            //ProjectionWithSelectMany();
            //Grouping.GroupByExample();
            //Grouping.GroupByUsingInto();
            //LetKeyword.RangeVariablesWithTheLetKeyword();
            //Outerjoin.OuterJoinEmployeesWithPensions();
            ContainsAndAny.Contains();

        }

        private static void ProjectionWithSelectMany()
        {
            throw new NotImplementedException();
        }

        private static void Projection()
        {
            string[] famousQuotes = {
                                        "Advertising is legalized lying",
                                        "Advertising is the greaterst art form of the twentieth centrury"

                                    };
            // when using comprehension syntax, having 2 froms is intepreted by the compiler as a SelectMany projection
            var result = (from sentence in famousQuotes
                          from word in sentence.Split(' ')
                          select word).Distinct().ToList();

            // here is the selectMany alternative. Efectively it flattens multiple sequences into one flat result.
            var selectManyResult = famousQuotes.SelectMany(s => s.Split(' ')).Distinct().ToList();
            
            // using extension methods syntax - this gives 2 results one for each sequence
            var result2 = famousQuotes.Select(s => s.Split(' ')).Distinct().ToList();

            // using extension methods to flatten the sequences
            var result3 = famousQuotes.SelectMany(s => s.Split(' ')).Distinct().ToList();

        }

        private static void Quantifiers()
        {
            var book = new Book
                           {
                               Author = "simon Ryan",
                               Title = "How to be a Dad"
                           };

            var bookValidationRules = new List<Func<Book, bool>>()
                                          {
                                            b => !String.IsNullOrEmpty(b.Author),
                                            b => !String.IsNullOrEmpty(b.Title),
                                            b => !b.Author.Contains("Miss"),
                                          };

        }
    }
}
