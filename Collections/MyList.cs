using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Collections
{
    public class MyList
    {
        public void Run()
        {
            var colours = new List<string>();

            colours.Add("Yellow");
            colours.Add("Green");
            colours.Add("Red");
            colours.Add("Blue");

            // Find
            string blue = colours.Find(item => item == "Blue");
            
            // exists
            bool green = colours.Exists(item => item == "Green");
            
            // find all matches
            List<string> all = colours.FindAll(item => item.Contains("e"));

            // get item by index
            var yellow = colours[0];

            // add range
            colours.AddRange(new[] {"Pink", "Purple"});

            // add more colours from a string
            var moreColours = "Orange, Lime, Turquoise, Pink";
            colours.AddRange(moreColours.Replace(" ", "").Split(','));

            // indexOf - found
            int found = colours.IndexOf("Green");

            // indexOf - not found
            int notFound = colours.IndexOf("White");

            // display items
            foreach (var colour in colours)
            {
                Console.WriteLine(colour);
            }
            

            Console.ReadKey();

        }
    }
}
