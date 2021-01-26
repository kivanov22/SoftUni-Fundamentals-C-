using System;

namespace _6.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";//prazen string


            if (input.Length % 2==0)
            {
                output = middleCharFromEvenLength(input);//method za even
                Console.WriteLine(output);
            }
            else
            {
                output = middleCharFromOddLength(input);//method za odd
                Console.WriteLine(output);
            }
        }

        private static string middleCharFromOddLength(string input)//Odd
        {
            int index = input.Length / 2;//delim na dve polovini
            string chars = input.Substring(index , 1);//edna bukva ili cifra 
            return chars;
        }

        private static string middleCharFromEvenLength(string input)//Even
        {
            int index = input.Length / 2;//delim na dve polovini
            string chars = input.Substring(index-1, 2);//izmestvame za dane vzima poslednite cifri ili chisla, 2 chisla ili 2 bukvi
            return chars;
        }
    }
}
