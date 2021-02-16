using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Emoji_Detector_two
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternEmojis = @"(\:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";//without the [] int the :*,escape them and put {2}exactly how much
            string patternDigits = @"[\d]";//maybe + or not check
            //coolness all ascii values
            //threshhold from digits

            string input = Console.ReadLine();

            Regex emojiRege = new Regex(patternEmojis);
            Regex digitsRegex = new Regex(patternDigits);

            long coolTreshold = 1;

            var validEmojis = emojiRege.Matches(input);
            var findNumbers = digitsRegex.Matches(input);

            var allNumbers = new List<int>();
            var coolEmojis = new List<string>();

            int countEmojis = validEmojis.Count;

            foreach (Match digit in findNumbers)
            {
                coolTreshold *= int.Parse(digit.Value);
            }

            foreach (Match match in validEmojis)
            {
                string emojiName = match.Groups["emoji"].Value;
                int sumOfName = 0;

                for (int i = 0; i < emojiName.Length; i++)
                {
                    char currentLetter = emojiName[i];
                    sumOfName += currentLetter;
                }

                if (sumOfName>coolTreshold)
                {
                    coolEmojis.Add(match.Value);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{countEmojis} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", coolEmojis));

        }
    }
}
