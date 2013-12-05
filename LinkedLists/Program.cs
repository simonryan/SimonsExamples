using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            list.AddNode(new Node<string>("Simon"));
            list.AddNode(new Node<string>("Emma"));
            list.AddNode(new Node<string>("Kate"));
            list.Display();

            var node = new Node<string>("Simon");
            list.Delete(node);

            Console.ReadLine();
        }
    }
}
