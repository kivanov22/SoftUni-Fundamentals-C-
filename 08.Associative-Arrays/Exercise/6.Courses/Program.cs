using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input.Split(" : ");
                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());//()) dont forget when using list

                }
                courses[courseName].Add(studentName);
                //we add to courseName in courses  the student name, we add student name cus we dont know how many students we gonna add

                input = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(x=>x.Value.Count))//count of students in course and pritn descending
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value.OrderBy(x=>x))//print students in ascending order , and we order them by course from previous foreach
                {
                    Console.WriteLine($"-- {item}");
                }
            }

            
        }
    }
}
