using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> collection = new List<Person>();
            string command = Console.ReadLine();

            while (command !="End")
            {
                string[] cmdArgs = command.Split();
                string Name = cmdArgs[0];
                string id = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);


                Person person = new Person(Name, id, age);

                collection.Add(person);

                command = Console.ReadLine();
            }
            foreach (Person person in collection.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }

        class Person
        {
            public Person(string name, string id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }

            public string Name { get; set; }

            public string Id { get; set; }

            public int Age { get; set; }
        }
    }
}
