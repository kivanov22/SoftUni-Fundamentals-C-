using System;
using System.Text;

namespace _7.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(word, count);
            Console.WriteLine(result);
        }

        static string RepeatString (string word,int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(word);
            }
            return result.ToString();
        }
    }
}
