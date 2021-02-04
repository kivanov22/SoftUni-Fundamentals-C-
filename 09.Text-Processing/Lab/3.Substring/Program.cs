using System;

namespace _3.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordRemove = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(wordRemove);

            while (index != -1)
            {
                text = text.Remove(index, wordRemove.Length);
                index = text.IndexOf(wordRemove);
            }
            Console.WriteLine(text);
        }
    }
}
