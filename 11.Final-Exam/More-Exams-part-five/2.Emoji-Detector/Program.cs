using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternValidEmojis = @"(\:{2}|\*{2})[A-Z][a-z]{2,}\1";//valid emojis
            string allDigitsPattern = @"\d";

            Regex regexValidEmojis = new Regex(patternValidEmojis);
            Regex regexAllDigits = new Regex(allDigitsPattern);

            string text = Console.ReadLine();

            
            long coolThreshhold = 1;

            regexAllDigits.Matches(text)
                .Select(m => m.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => coolThreshhold *= x);

            var matches = regexValidEmojis.Matches(text);//matchcollection storing all matches in the input
            int totalEmojis = matches.Count;//count of emojis

            List<string> coolEmojis = new List<string>();//list of cool emojis

            foreach (Match item in matches)
            {
               long coolIndex = item.Value.Substring(2, item.Value.Length - 4)
                    .ToCharArray()//parse to toChar 
                    .Sum(x=>(int)x);// here we parse every char to int ,middle part of the emoji :: this ::

                if (coolIndex>coolThreshhold)
                {
                    coolEmojis.Add(item.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshhold}");
            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");

            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
