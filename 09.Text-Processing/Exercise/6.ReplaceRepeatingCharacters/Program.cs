using System;
using System.Text;

namespace _6.ReplaceRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length-1; i++)//so it doesn't give us index out of range
            {
                
                if (text[i]!=text[i+1])//check if first symbol is different then the next
                {
                    sb.Append(text[i]);// add the symbol to stringbuilder

                }
            }
            var symbol = text[text.Length - 1];//we take the last symbol and add it to the  sb
            sb.Append(symbol);
            Console.WriteLine(sb.ToString());
        }
    }
}
