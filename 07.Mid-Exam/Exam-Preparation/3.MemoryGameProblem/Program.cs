using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MemoryGameProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenceElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = "";
            int countMoves = 0;
            bool isWinner = false;

            while ((input = Console.ReadLine()) != "end")
            {
                countMoves++;
                string[] cmdArg = input.Split();
                int firstIndex = int.Parse(cmdArg[0]);
                int secondIndex = int.Parse(cmdArg[1]);



                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < sequenceElements.Count && secondIndex < sequenceElements.Count
                && firstIndex != secondIndex)
                {
                    if (sequenceElements[firstIndex] == sequenceElements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequenceElements[firstIndex]}!");

                        if (firstIndex > secondIndex)//so when we remove from collection 0 index item the collection doesn't move
                        {
                            sequenceElements.RemoveAt(firstIndex);
                            sequenceElements.RemoveAt(secondIndex);
                        }
                        else
                        {
                            sequenceElements.RemoveAt(secondIndex);
                            sequenceElements.RemoveAt(firstIndex);
                        }
                        if (sequenceElements.Count == 0 || sequenceElements.Count == 1)
                        {
                            isWinner = true;
                            Console.WriteLine($"You have won in {countMoves} turns!");

                            return;
                        }
                    }
                    else if (sequenceElements[firstIndex] != sequenceElements[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    //countMoves++;
                    string addElements = $"-{countMoves}a";
                    //int findMiddle = sequenceElements.Count / countMoves;
                    //2 instead of find middle which means count is not always the case to divide
                    sequenceElements.Insert(sequenceElements.Count / 2, addElements);
                    sequenceElements.Insert(sequenceElements.Count / 2, addElements);
                }
            }
            if (isWinner == false)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequenceElements));
            }

        }
    }
}
