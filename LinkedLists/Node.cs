using System;

namespace LinkedLists
{
    public class Node<T> where T : IComparable
    {
        public T Value { get; set; }

        public Node(T val)
        {
            Value = val;
        }
        public Node<T> Next { get; set; }
    }
}
