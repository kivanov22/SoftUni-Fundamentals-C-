using System;
using System.Numerics;

namespace _2.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = 1;//when we multiply we use 1 instead of 0

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
