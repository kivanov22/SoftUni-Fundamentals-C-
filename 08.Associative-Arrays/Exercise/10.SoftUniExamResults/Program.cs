using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.List,int as dictionary
            //2.while loop till end command
            //3.if we receive command ban, we remove the user but keep his points and submissions
            //4.Foreach loop
            //4.1 -after end command we print user points in descending and then by username.Results
            //5.print each language, used in the exam, ordered descending by total submission count and then by language name.Submissions
            //6.points are int
            //7.count submissions in each language

            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (command != "exam finished")
            {
                string[] cmdArgs = command.Split("-");
                string studentName = cmdArgs[0];

                if (cmdArgs.Length > 2)//cmdArgs.Length >2  !cmdArgs.Contains("banned")
                {
                    //string[] cmdArgs = command.Split("-");
                    //string studentName = cmdArgs[0];
                    string language = cmdArgs[1];
                    int studentPoints = int.Parse(cmdArgs[2]);

                    if (!results.ContainsKey(studentName))
                    {
                        results.Add(studentName, studentPoints);
                    }
                    else
                    {
                        if (results[studentName]<studentPoints)// current student 's first points are more than current points
                        {
                            results[studentName] = studentPoints;
                        }      
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);//we set 0 as a counter
                    }

                    submissions[language]++;//we increase submissions
                }
                else
                {
                    //string[] cmdArgs = command.Split("-");
                    //string studentName = cmdArgs[0];
                    results.Remove(studentName);

                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Results:");//out of the foreach so we dont print them every with every student

            foreach (var student in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                
                Console.WriteLine($"{student.Key} | {student.Value}");

                
            }
            Console.WriteLine("Submissions:");

            foreach (var sub in submissions.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
                {
                    
                    Console.WriteLine($"{sub.Key} - {sub.Value}");
                }
        }
    }
}
