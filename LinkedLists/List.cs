using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class List<T>
    {
        Node<T> Head { get; set; }

        public void AddNode(Node<T> newNode)
        {
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var node = Head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = newNode;
            }
        }

        public void Display()
        {
            var node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        public void Delete(T val)
        {
            if (Head.Value.Equals(val))
            {
                
            }
        }
    }
}
