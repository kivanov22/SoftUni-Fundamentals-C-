using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> output = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();//we take from console commands
                string task = cmdArgs[0];
                string userName = cmdArgs[1];
                

                if (task=="register")
                {
                    string license = cmdArgs[2];
                    if (!output.ContainsKey(userName))
                    {
                        output.Add(userName, license);
                        Console.WriteLine($"{ userName} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }
                else if (task=="unregister")
                {
                    if (!output.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        output.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }

            }

            foreach (var user in output)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
