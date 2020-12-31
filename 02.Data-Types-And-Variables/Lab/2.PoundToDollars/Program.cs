using System;

namespace _2.PoundToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal pound = decimal.Parse(Console.ReadLine());

            decimal dollar = pound * 1.31M;
            Console.WriteLine($"{dollar:f3}");
        }
    }
}
