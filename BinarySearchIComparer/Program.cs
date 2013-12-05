using System;
using System.Collections;

namespace BinarySearchIComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[10]
                {
                    new Person("Simon", 40), 
                    new Person("Emma", 36), 
                    new Person("Kate", 42), 
                    new Person("Nicola", 55), 
                    new Person("Darren", 21), 
                    new Person("Graham", 43), 
                    new Person("Harry", 13), 
                    new Person("Sebastian", 13), 
                    new Person("Holly", 17), 
                    new Person("Sue", 60), 
                };


            var personToFind = new Person("Holly", 17);
            FindPersonByName(people, personToFind);

            // add another item to the array then find by age
            var anotherPerson = new Person("Blobby", 99);
            var temp = new Person[people.Length + 1];
            people.CopyTo(temp, 0);
            people = temp;
            people[people.Length] = anotherPerson;

            Array.Sort(people, new CompareByAge());
            Array.BinarySearch(people, new Person("Blobby", 99), new CompareByAge());
            int position = Array.BinarySearch(people, findName, new CompareByName());
            Person found = people[position];
            Console.WriteLine("Person of age {0} found at position {1} in the array", found.Name, position);

        }

        private static void FindPersonByName(Person[] people, Person personToFind)
        {
            Array.Sort(people, new CompareByName());
            
            var position = Array.BinarySearch(people, personToFind, new CompareByName());
            var found = people[position];
            Console.WriteLine("{0} was found at position {1} in the array", found.Name, position);
        }
    }
}
