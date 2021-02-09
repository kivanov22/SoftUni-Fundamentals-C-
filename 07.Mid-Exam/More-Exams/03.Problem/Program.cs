using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectionWords = Console.ReadLine().Split(" ").ToList();

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];

                if (action == "Delete")
                {
                    int index = int.Parse(cmdArgs[1]);
                    //int index = int.Parse(cmdArgs[1]);
                    //collectionWords.RemoveAt(index + 1);//+!
                    if (index >= 0 && index <= collectionWords.Count)
                    {

                        collectionWords.RemoveAt(index + 1);//+!
                    }

                }
                else if (action == "Swap")
                {
                    string firstWord = cmdArgs[1];
                    string secondWord = cmdArgs[2];

                    if (collectionWords.Contains(firstWord) && collectionWords.Contains(secondWord))
                    {

                        int firstIndex = collectionWords.IndexOf(firstWord);
                        int secondIndex = collectionWords.IndexOf(secondWord);

                        string temp = collectionWords[firstIndex];
                        collectionWords[firstIndex] = collectionWords[secondIndex];
                        collectionWords[secondIndex] = temp;

                    }
                }
                else if (action == "Put")
                {
                    string word = cmdArgs[1];
                    int newIndex = int.Parse(cmdArgs[2]);

                    if (newIndex >= 0 && newIndex < collectionWords.Count)
                    {
                        collectionWords.Insert(newIndex - 1, word);
                        //collectionWords[newIndex - 1] = word;
                    }
                }
                else if (action == "Sort")
                {
                    collectionWords.OrderByDescending(x => x);


                }
                else if (action == "Replace")
                {
                    string word1 = cmdArgs[1];
                    string word2 = cmdArgs[2];

                    if (collectionWords.Contains(word2))
                    {
                        int first = collectionWords.IndexOf(word2);
                        // int second = collectionWords.IndexOf(word2);
                        //int second = collectionWords.IndexOf(word2+ 1);

                        // string temp = collectionWords[first];
                        collectionWords[first] = word1;
                        // collectionWords.RemoveAt(first+1);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", collectionWords));
        }
    }
}
