using System;

namespace BinarySearchIComparer
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public String Name { get; private set; }
        public int Age { get; private set; }
    }
}
