using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> someData = Console.ReadLine().Split().ToList();

            

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];

                if (command == "3:1")
                {
                    break;
                }


                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                string concateWord = "";

                if (endIndex > someData.Count - 1 || endIndex < 0)
                {
                    endIndex = someData.Count - 1;
                }
                if (startIndex < 0 || startIndex > someData.Count)
                {
                    startIndex = 0;
                }

                if (command == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concateWord += someData[i];
                    }
                    someData.RemoveRange(startIndex, endIndex - startIndex + 1);
                    someData.Insert(startIndex, concateWord);

                }
                else if (command == "divide")
                {
                    List<string> divided = new List<string>();
                    int divide = int.Parse(commands[2]);
                    string word = someData[startIndex];
                    someData.RemoveAt(startIndex);
                    int parts = word.Length / divide;

                    for (int i = 0; i < divide; i++)
                    {
                        if (i == divide - 1)
                        {
                            divided.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            divided.Add(word.Substring(i * parts, parts));
                        }
                    }
                    someData.InsertRange(startIndex, divided);
                }
            }
            Console.WriteLine(string.Join(" ",someData));
        }
    }
}
