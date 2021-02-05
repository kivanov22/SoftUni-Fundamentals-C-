using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Exe_ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "Lumpawaroo")
            {

                if (command.Contains("|"))
                {
                    string[] commandArr = command.Split(" | ");

                    string forceSide = commandArr[0];
                    string forceUser = commandArr[1];

                    if (!forceUsers.ContainsKey(forceSide))
                    {
                        forceUsers.Add(forceSide, new List<string>());
                    }
                    if (!forceUsers[forceSide].Contains(forceUser))
                    {
                        forceUsers[forceSide].Add(forceUser);
                    }
                }

                else
                {
                    string[] commandArr = command.Split(" -> ");

                    string forceUser = commandArr[0];
                    string forceSide = commandArr[1];


                    if (!forceUsers.ContainsKey(forceSide))
                    {
                        forceUsers.Add(forceSide, new List<string>());
                    }

                    forceUsers[forceSide].Add(forceUser);

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                    foreach (var values in forceUsers)
                    {
                        if (values.Value.Contains(forceUser) && values.Key != forceSide)
                        {
                            values.Value.Remove(forceUser);
                            break;
                        }
                    }

                }

                command = Console.ReadLine();
            }

            foreach (var users in forceUsers.OrderByDescending(x => x.Value.Count).ThenBy(c => c.Key))
            {
                if (users.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {users.Key}, Members: {users.Value.Count}");
                }

                foreach (var elm in users.Value.OrderBy(t => t))
                {
                    Console.WriteLine($"! {elm}");
                }
            }
        }
    }
}