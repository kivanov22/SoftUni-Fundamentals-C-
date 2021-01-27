using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                            .Split("|")
                                            .ToList();
            numbers.Reverse();

            List<string> finalList = new List<string>();//empty for the final result

            foreach (string items in numbers)//going through the list
            {
                string[] removeSpaces = items.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();//array for removing spaces

                foreach (string numbersToAdd in removeSpaces)//adding numbers to finalList
                {
                    finalList.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ",finalList));
        }
    }
}
