using System;
using System.Linq;

namespace array_sample_2
{
    internal class Program
    {

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        static void Main()
        {

            Person[] people = new Person[3];
            people[0] = new Person("Alice", 25);
            people[1] = new Person("Bob", 35);
            people[2] = new Person("Charlie", 35);

            //
            var selectedPeople = people.Where(p => p.Age > 30);

            foreach (var person in selectedPeople)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("");

            //alphabetical name sorting
            var sortedPeople = people.OrderBy(p => p.Name);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.Name);
            }

            //age sorting, can't use both
            /* 
            var sortedPeople = people.OrderBy(p => p.Age);
            
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.Age);
            }*/


        }

    }
}