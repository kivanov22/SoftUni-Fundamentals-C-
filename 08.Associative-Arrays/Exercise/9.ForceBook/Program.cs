using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> forceRegister = new Dictionary<string,string>();


            string commands = Console.ReadLine();

            while (commands != "Lumpawaroo")
            {
                if (commands.Contains("|"))
                {
                    string[] cmdArgs = commands.Split(" | ");
                    string side = cmdArgs[0];
                    string name = cmdArgs[1];

                    if (!forceRegister.ContainsKey(name))
                    {
                        forceRegister.Add(name,side);//switched the values side,name
                    }
                    //if (!forceRegister[side].Contains(name))
                    //{
                    //    forceRegister[side].Add(name);
                    //}
                    //forceRegister[side].Add(name);
                }
                else if (commands.Contains("->"))
                {
                    string[] cmdArgs = commands.Split(" -> ");
                    string name = cmdArgs[0];
                    string side = cmdArgs[1];

                    if (forceRegister.ContainsKey(name))
                    {
                       
                        forceRegister[name] = side;
                    }
                    else
                    {
                        forceRegister.Add(name, side);
                       
                    }
                    Console.WriteLine($"{name} joins the {side} side!");

                }


                commands = Console.ReadLine();
            }

            foreach (var users in forceRegister
               .GroupBy(x => x.Value)
               .OrderByDescending(x => x.Count())
               .ThenBy(c => c.Key))
            {
                Console.WriteLine($"Side: {users.Key}, Members: {users.Count()}");

                foreach (var elm in users.OrderBy(t => t.Key))
                {
                    Console.WriteLine($"! {elm.Key}");
                }
            }

        }
    }
}
