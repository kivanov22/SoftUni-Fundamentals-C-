using System;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split();

            var firstWord = tokens[0];
            var secondWord = tokens[1];

            var longestWord = firstWord;
            var shortestWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }
            var total = CharMultiplier(longestWord, shortestWord);
            Console.WriteLine(total);
        }
        public static int CharMultiplier(string longestWord,string shortestWord)
        {
            var sum = 0;

            for (int i = 0; i < shortestWord.Length; i++)
            {
                var multiply = longestWord[i] * shortestWord[i];//chacters and takes the ascii 
                sum += multiply;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }
            return sum;
        }
    }
}
