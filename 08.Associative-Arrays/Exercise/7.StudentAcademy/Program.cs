using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>> students = new Dictionary<string,List< double>>();//we need a list for the grades

            int numberStudents = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberStudents; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName,new List<double>());
                }
                students[studentName].Add(studentGrade);//we need to add the grade if the student already exists
            }
            

            foreach (var student in students.OrderByDescending(x=>x.Value.Average()))//when we have list we do a average function
            {
                if (student.Value.Average()>=4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
