using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command!="Done")
            {
                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];

                if (action== "Change")
                {
                    char letter = char.Parse(cmdArgs[1]);
                    char replacement = char.Parse(cmdArgs[2]);

                 input= input.Replace(letter, replacement);
                    Console.WriteLine(input);//maybe no print
                }
                else if (action=="Includes")
                {
                    string word = cmdArgs[1];

                    if (input.Contains(word))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action=="End")
                {
                    string endString = cmdArgs[1];

                    bool endwith = input.EndsWith(endString);

                    if (endString=="true")
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action=="Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (action=="FindIndex")
                {
                    char index = char.Parse(cmdArgs[1]);
                   int findIndex = input.IndexOf(index);
                    Console.WriteLine(findIndex);
                }
                else if (action=="Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                   // string firstpart = input.Substring(0, startIndex);
                    string secondpart = input.Substring(startIndex, length);
                   //input= input.Remove(0,startIndex);
                   // input = input.Remove(startIndex, length);
                   // int secondPart = input.Remove(length, input.Length);
                    Console.WriteLine(secondpart);
                }
                command = Console.ReadLine();
            }
        }
    }
}
