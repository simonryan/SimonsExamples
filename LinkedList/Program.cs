using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();
            linkedList.Add(new Node("first"));
            linkedList.Add(new Node("second"));
            linkedList.Add(new Node("third"));
            linkedList.Add(new Node("forth"));

            linkedList.Display();

            var node = linkedList.Find(1);
            Console.WriteLine("Found: {0}", node != null ? node.data : "not found");

            /*var position = 3;
            Console.WriteLine("Deleting node {0}", position);
            linkedList.DeleteNode(position);*/

            linkedList.AddNode(1, new Node("simon"));

            linkedList.Display();

            Console.Read();
        }
    }
}
