using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _2.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> sequenceIntegers = Console.ReadLine().Split().Select(long.Parse).ToList();

            string input = Console.ReadLine();

            List<long> emptyNumbers = new List<long>();

            emptyNumbers = sequenceIntegers;
            while (input != "end")
            {
                string[] cmdArgs = input.Split(" ");
                //string command = cmdArgs[0];
                //int firstIndex = int.Parse(cmdArgs[1]);
                //int secondIndex = int.Parse(cmdArgs[2]);


                long multiply = 0;
                long deacrease = 1;

                if (cmdArgs[0] == "swap")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int secondIndex = int.Parse(cmdArgs[2]);

                    long currentNumber = emptyNumbers[firstIndex];
                    emptyNumbers[firstIndex] = emptyNumbers[secondIndex];
                    emptyNumbers[secondIndex] = currentNumber;

                }
                if (cmdArgs[0] == "multiply")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int secondIndex = int.Parse(cmdArgs[2]);

                    multiply = emptyNumbers[firstIndex] * emptyNumbers[secondIndex];
                    emptyNumbers[firstIndex] = multiply;
                }
                if (cmdArgs[0] == "decrease")
                {
                    for (int i = 0; i < emptyNumbers.Count; i++)
                    {
                        long currentElement = emptyNumbers[i];
                        emptyNumbers[i] = emptyNumbers[i] - 1;
                        //deacrease -= currentElement;
                        //currentElement

                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",emptyNumbers));
        }
    }
}
