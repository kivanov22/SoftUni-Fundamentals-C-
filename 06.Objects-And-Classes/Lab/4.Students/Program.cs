using System;
using System.Collections.Generic;

namespace _4.Students
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }
            public string Hometown { get; set; }
        }
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(" ");

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string hometown = tokens[3];


                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Hometown = hometown;

                students.Add(student);
                input = Console.ReadLine();

            }
            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown==filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is { student.Age} years old.");
                }
            }
        }
    }
}
