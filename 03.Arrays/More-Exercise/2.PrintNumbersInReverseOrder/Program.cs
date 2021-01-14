using System;

namespace _2.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];//array for storing numbers

            for (int i = 0; i < n; i++)
            {

                int number = int.Parse(Console.ReadLine());

                numbers[i] = number;

            }
            for (int i = numbers.Length - 1; i >= 0; i--)//cikul za izpisvane na chislata v obraten red
            {
                Console.Write(numbers[i]+ " ");
            }
        }
    }
}
