using System;

namespace _4.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// we receive a number

            int sum = 0;

            for (int i = 0; i < n; i++) // loop for 0 till n times
            {
                char input = char.Parse(Console.ReadLine());// take a char value "A"= 65 ASCII number for example.
                sum += input;
                //ASCII numbers sum of the letters.
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
