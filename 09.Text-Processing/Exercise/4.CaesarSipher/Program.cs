using System;

namespace _4.CaesarSipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();// we take it as one string

            foreach (char ch in input)//for each char in string input
            {
                var currentChar = (char)(ch + 3);//without brackets on ch+3 its int , not char

                Console.Write(currentChar);
            }
        }
    }
}
