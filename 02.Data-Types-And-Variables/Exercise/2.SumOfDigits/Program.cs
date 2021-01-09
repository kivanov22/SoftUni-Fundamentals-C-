using System;

namespace _2.SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i].ToString());
                 sum+= currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
