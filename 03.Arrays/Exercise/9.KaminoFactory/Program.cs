using System;

namespace _9.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string input = "";//empty string
            int counter = 0;
            int bestCount = 0;
            int bestBeginIndex = 0;
            int bestSum = 0;
            string bestSequance = "";
            int bestCounter = 0;

            while ((input=Console.ReadLine()) !="Clone them!")//run cycle til we get from console Clone them
            {
                string sequence = input.Replace("!", ""); // we remove ! and put space
                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);//removes spaces between numbers in array
                // we get only 111 from dnaParts

                int count = 0;
                int sum = 0;
                string bestSubSequance = "";

                counter++;

                foreach (string dnaPart in dnaParts)// 
                {
                    if (dnaPart.Length>count)
                    {
                        count = dnaPart.Length;//we set count to the longest sequance 3
                        bestSubSequance = dnaPart;//best sequance to the current dnaPart
                    }
                    sum += dnaPart.Length;//we add to sum dnaPart
                }
                int beginIndex = sequence.IndexOf(bestSubSequance);// returns the index which has the best sequance of dna.//instead of making a for loop

                if (count > bestCount ||
                    (count == bestCount && beginIndex < bestBeginIndex) ||
                    (count == bestCount && beginIndex == bestBeginIndex && sum > bestSum))
                {
                    bestCount = count;
                    bestSequance = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }
            }
            char[] result = bestSequance.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}
