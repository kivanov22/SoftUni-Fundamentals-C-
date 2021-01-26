using System;
using System.Xml.Schema;

namespace _9.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            IsitPalindrome(input);


        }

        private static void IsitPalindrome(string input)
        {
            string reversed = "";//saves the reversed string for example 123 to 321

            while (input!="END")
            {
                input = Console.ReadLine();

                if (input=="END")
                {
                    break;
                }
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }
                if (reversed!=input)
                {
                    Console.WriteLine("false");
                }
                else if (reversed==input)
                {
                    Console.WriteLine("true");
                }
                reversed = "";
            }
        }
    }
}
