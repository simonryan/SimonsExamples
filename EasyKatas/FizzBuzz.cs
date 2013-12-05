using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyKatas.Extensions;

namespace EasyKatas
{
    public class FizzBuzz
    {
        public static void Start()
        {
            var input = Console.ReadLine();
            int num;

            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Not a number");
                return;
            }
            
            Console.WriteLine(num.FizzBuzz());

        }


        public bool DivisableByThree(int i)
        {
            if (i == 0) return false;
            return i%3 == 0;
        }

        public bool DivisableByFive(int i)
        {
            if (i == 0) return false;
            return i%5 == 0;
        }
    }
}
