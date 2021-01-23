﻿using System;

namespace _1.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNumberSign(number);
        }


        static void PrintNumberSign(int number)
        {
            if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }



    }
}
