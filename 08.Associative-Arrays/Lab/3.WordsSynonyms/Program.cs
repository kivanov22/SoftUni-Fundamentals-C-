using System;
using System.Collections.Generic;

namespace _3.WordsSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWords = int.Parse(Console.ReadLine());
            Dictionary<string,List<string>> words = new Dictionary<string,List<string>>();

            for (int i = 0; i < countWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    
                    words[word].Add(synonym);
                }
                else
                {
                    words.Add(word, new List<string>() {synonym});
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value) }");
            }
        }
    }
}
