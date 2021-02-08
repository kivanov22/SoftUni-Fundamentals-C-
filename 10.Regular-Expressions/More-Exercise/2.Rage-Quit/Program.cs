using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            //1-regex for words
            //1-regex for numbers
            //1-regex for symbols

            //string patternWords = @"([A-Za-z]+?)";
            //string patternNumbers = @"(\d+?)";
            //string patternSymbols = @"(\W+?)";
            string pattern = @"(?<text>[\D]+)(?<number>[\d]+)";

            HashSet<char> uniqueChars = new HashSet<char>();//storing unique chars

            MatchCollection matches = Regex.Matches(message, pattern); //match collection for matches

            StringBuilder result = new StringBuilder();

            foreach (Match item in matches)
            {
                string text = item.Groups["text"].Value.ToUpper();
                int number = int.Parse(item.Groups["number"].Value);

                if (number>0)
                {
                    foreach (var ch in text)
                    {
                        uniqueChars.Add(ch);
                    }
                }

                for (int i = 0; i < number; i++)
                {
                    result.Append(text);
                }

            }
            Console.WriteLine($"Unique symbols used: {uniqueChars.Count}");
            Console.WriteLine(result.ToString());
        }
    }
}
