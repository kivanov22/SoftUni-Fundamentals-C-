using System;

namespace _1.Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int first = number1 + number2;
            int sum = first / number3;
            int multy = sum * number4;

            Console.WriteLine(multy);
        }
    }
}
