using System;
using System.Linq;

namespace _8.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <arr.Length; i++)
            {
                int currentNumber = arr[i];// taking the current number from array

                for (int j = i+1; j < arr.Length; j++)// for taking the next element
                {
                    int secondNumber = arr[j];//taking the second number from array

                    if (currentNumber + secondNumber==number)//check if the sum of both numbers gives the number 
                    {
                        Console.WriteLine($"{currentNumber} {secondNumber}");
                        break;
                    }
                }
            }
        }
    }
}
