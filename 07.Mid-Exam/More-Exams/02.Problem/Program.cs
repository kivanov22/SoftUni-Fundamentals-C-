using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cookies = Console.ReadLine().Split(", ").ToList();
            string wordToRemove = "";
            string command = Console.ReadLine();
            List<string> newList = new List<string>();

            while (command!="Eat")
            {
                string[] cmdArgs = command.Split(" ");
                string action = cmdArgs[0];
                
                if (action=="Update-Any")
                {
                    string name = cmdArgs[1];
                    string replace = "Out of Stock";
                    wordToRemove = replace;
                    
                        for (int i = 0; i < cookies.Count; i++)
                        {
                        string currentCookie = cookies[i];

                            if (currentCookie==name)
                            {
                                cookies[i] = replace;
                            }
                        }
                    
                }
                else if (action=="Remove")
                {
                    string biscuit = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);

                    if (index>=0 && index<cookies.Count)
                    {
                        cookies[index] = biscuit;
                    }
                }
                else if (action=="Update-Last")
                {
                    string newBiscuit = cmdArgs[1];

                    cookies[cookies.Count - 1] = newBiscuit;
                }
                else if (action=="Rearrange")
                {
                    string changeBiscuit = cmdArgs[1];

                    if (cookies.Contains(changeBiscuit))
                    {
                        cookies.Remove(changeBiscuit);
                        cookies.Add(changeBiscuit);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var cookie in cookies)
            {
                if (cookie!=wordToRemove)
                {
                    newList.Add(cookie);
                }
            }
            //cookies.Remove(wordToRemove);
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
