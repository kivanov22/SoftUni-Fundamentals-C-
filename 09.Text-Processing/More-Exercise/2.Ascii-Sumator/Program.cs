using System;

namespace _2.Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int sum = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                int currentElement = text[i];

                if (currentElement> firstChar && currentElement<secondChar)
                {
                    sum += currentElement;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
