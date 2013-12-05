using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /// <summary>
    /// Keys and values
    /// Keys must be unique
    /// Great performance
    /// Unsorted and no sort method
    /// </summary>
    public class MyDictionary
    {
        private Dictionary<string, int> pets;
        public MyDictionary()
        {
            pets = new Dictionary<string, int>
                {
                    {"Cats", 2}, 
                    {"Dogs", 1}, 
                    {"Fish", 12},
                    {"Horse", 1}
                };
        }

        public void Run()
        {
            // ContainsKey - item exists
            bool exists = pets.ContainsKey("Dogs");

            // Contains - particular value
            bool found = pets.ContainsValue(1);

            // get value by key
            int result = pets["Fish"];

            // have to test key exists before getting value by key or risk exception
            if (pets.ContainsKey("Fish"))
            {
                pets["Fish"] ++;
            }

            // better method is to use TryGetValue
            int value;
            if (pets.TryGetValue("Fish", out value))
            {
                pets["Fish"] = value + 1;
            }

        }
    }
}
