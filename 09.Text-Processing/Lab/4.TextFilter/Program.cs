using System;

namespace _4.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();

            foreach (string word in banWords)
            {
                if (input.Contains(word))//check if input has word from banWords
                {
                    input = input.Replace(word, new string('*', word.Length));//replace old word with * and find word's Length
                }
            }
            Console.WriteLine(input);
        }
    }
}
