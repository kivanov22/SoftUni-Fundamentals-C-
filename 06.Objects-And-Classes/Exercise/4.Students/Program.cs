using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countStudents; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");

                string firstName = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);


                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            //can be done without the sorted list and we can do a override method
             students= students.OrderByDescending(x => x.Grade).ToList();
            List<Student> sortedStudents = students.OrderByDescending(x => x.Grade).ThenBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (Student x in sortedStudents)
            {
                //we can do it with only x print
                Console.WriteLine($"{x.FirstName} {x.LastName}: {x.Grade:f2}");
            }
            
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
}
