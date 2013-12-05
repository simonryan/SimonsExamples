using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyKatas
{
    public class FibonacciKillerKata
    {
        public static void Start()
        {
            string n = Console.ReadLine();
            uint number;
            uint fibonacciValue;

            if (uint.TryParse(n, out number))
            {
                var fibonacci = new FibonacciKillerKata();
                fibonacciValue = fibonacci.Fibonacci(number);
            }
            else
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine(fibonacciValue);
        }

        public uint Fibonacci(uint n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            
            uint result = 0;
            uint nMinus1 = 0;
            uint nMinus2 = 1;

            for (var i = 0; i < n; i++)
            {
                result = nMinus1 + nMinus2;
                nMinus2 = nMinus1;
                nMinus1 = result;
            }

            return result;
        }

        public interface IFibonacciKillerKata
        {
            /// <summary>
            /// Calculate an element of the Fibonacci sequence
            /// </summary>
            /// <param name="n">element number</param>
            /// <returns>n-th element of the Fibonacci sequence</returns>
            int Fibonacci(int n);
        }
    }
}