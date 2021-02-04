using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split("->");
                string company = cmdArgs[0];
                string employeeId = cmdArgs[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }
                if (!companies[company].Contains(employeeId))//check if the company doesn't already have the employe
                {
                    companies[company].Add(employeeId);
                }
               


                command = Console.ReadLine();
            }
            foreach (var item in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var employe in item.Value)
                {
                    Console.WriteLine($"-- {employe}");
                }
            }
        }
    }
}
