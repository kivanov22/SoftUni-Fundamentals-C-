using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mirror_Words_two
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validWords = new List<string>();

            string pattern = @"(@|#)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection match = regex.Matches(input);

            int counter = 0;
            foreach (Match item in match)
            {
                if (item.Success)
                {
                    string first = item.Groups["first"].Value;
                    string second = item.Groups["second"].Value;

                    char[] secondChar = second.ToCharArray();
                    Array.Reverse(secondChar);
                    string secondWord = new string(secondChar);


                    if (first == secondWord)
                    {
                        string mirror = first + "<=>" + secondWord;
                        validWords.Add(mirror);
                    }

                }
                counter++;
            }



            if (counter == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{counter} word pairs found");
            }
             if (validWords.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(",", validWords));
            }
        }
    }
}
