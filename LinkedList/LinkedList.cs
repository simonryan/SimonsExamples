using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node current;

        public void Add(Node n)
        {
            if (head == null)
            {
                head = n;
                current = head;
            }
            current.next = n;
            current = current.next;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            var node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public Node Find(int position)
        {
            int count = 1;
            Node currentNode = head;
            Node foundNode = null;
            
            while (currentNode != null)
            {
                if (count == position)
                {
                    foundNode = currentNode;
                }
                currentNode = currentNode.next;
                count++;
            }
            return foundNode;
        }

        public bool DeleteNode(int position)
        {
            if (position == 1)
            {
                head = null;
                return true;
            }

            Node currentNode = head.next;
            Node previousNode = head;
            int counter = 2;
            while (currentNode != null)
            {
                if (counter == position)
                {
                    previousNode.next = currentNode.next;
                    return true;
                }
                counter++;
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
            return false;
        }

        public bool AddNode(int position, Node newNode)
        {
            int counter = 1;
            Node currentNode = head;

            if (currentNode == null)
            {
                head = newNode;
            }

            if (position == 1)
            {
                newNode.next = head.next;
                head.next = newNode;
                return true;
            }
            
            while (currentNode != null)
            {
                if (position == counter + 1)
                {
                    newNode.next = currentNode.next;
                    currentNode.next = newNode;
                    return true;
                }
                currentNode = currentNode.next;
                counter++;
            }
            return false;
        }
    }
}
