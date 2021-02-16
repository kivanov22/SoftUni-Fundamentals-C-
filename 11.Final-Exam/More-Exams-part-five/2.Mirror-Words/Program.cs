using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2.Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> mirrorWords = new List<string>();

            string pattern = @"(@|#)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            Regex regexMirrorWords = new Regex(pattern);

            MatchCollection matches = regexMirrorWords.Matches(input);

            int counter = 0;

            foreach (Match item in matches)
            {

                if (item.Success)
                {
                    string firstWord = item.Groups["first"].Value;
                    string secondWord = item.Groups["second"].Value;

                    char[] secondChar = secondWord.ToCharArray();//array of chars
                    Array.Reverse(secondChar);//reverse the chars
                    string secondReversed = new string(secondChar);//from char to string again,but now reversed

                    if (firstWord==secondReversed)//if the words are equal
                    {
                        string mirror = firstWord + " <=> " + secondWord;
                        mirrorWords.Add(mirror);
                    }



                }

                counter++;
            }

            if (counter==0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{counter} word pairs found!");
            }
            if (mirrorWords.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                
                 Console.Write(string.Join(", ",mirrorWords));
                  
            }


        }
    }
}
