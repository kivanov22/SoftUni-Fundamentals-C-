using System;

namespace _3.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintBetween(firstChar, secondChar);
        }

        private static void PrintBetween(char firstChar, char secondChar)
        {
            if (firstChar>secondChar)
            {
                char first = firstChar;//take first char 
                firstChar = secondChar;//swap char a,b = b,a
                secondChar = first;//we save ourselfs second loop
            }

            for (int i = firstChar+1; i < secondChar; i++)// loop for goign through the chars betweeen first and second
            {
                Console.Write((char)i+ " ");// cast the index to char
            }
        }
    }
}
