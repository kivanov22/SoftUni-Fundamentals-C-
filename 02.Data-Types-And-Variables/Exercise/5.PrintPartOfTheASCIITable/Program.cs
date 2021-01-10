using System;

namespace _5.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            

            for (int i = number1; i <= number2; i++)
            {
                Console.Write($"{(char)i} ");
            }
           
        }
    }
}
