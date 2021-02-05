using System;
using System.Collections.Generic;

namespace _1.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurencies = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter!=' ')
                {
                    if (!occurencies.ContainsKey(letter))
                    {
                        occurencies.Add(letter, 0);
                    }
                    occurencies[letter]++;
                }
            }

            foreach (var c in occurencies)
            {
                char currentKey = c.Key;
                int currentValue = c.Value;//define them before output so we dont write them c.Key in console

                Console.WriteLine($"{currentKey} -> {currentValue}");
            }


        }
    }
}
