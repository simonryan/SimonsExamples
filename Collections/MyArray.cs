using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /// <summary>
    /// Fixed size collection of same types
    /// Arrays are indexed
    /// </summary>
    public class MyArray
    {
        private string[] stringArray; 
        public MyArray()
        {
            stringArray = new[] {"Yellow", "Green", "Red"};
        }
        public void Run()
        {
            // get value by index
            var yellow = stringArray[0];
            stringArray[0] = yellow;

            string words = "Hello how are you";
            string[] greeting = words.Split(' ');
            Console.WriteLine(string.Join(" ", greeting));

            Console.WriteLine(words.Reverse());



            // display all items
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

        }
    }
}
