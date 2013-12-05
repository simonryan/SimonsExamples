using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyKatas.Extensions
{
    public static class Extensions
    {
        public static string FizzBuzz(this int num)
        {
            var fizzBuzz = new FizzBuzz();

            if (fizzBuzz.DivisableByThree(num) && fizzBuzz.DivisableByFive(num))
            {
                return "FizzBuzz";
            }
            if (fizzBuzz.DivisableByThree(num))
            {
                return "Fizz";
            }
            if (fizzBuzz.DivisableByFive(num))
            {
                return "Buzz";
            }
            return num.ToString();
        }
    }
}
