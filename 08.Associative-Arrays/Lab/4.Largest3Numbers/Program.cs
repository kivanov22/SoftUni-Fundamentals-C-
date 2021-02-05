using System;
using System.Linq;

namespace _4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).ToArray();

            //int[] sorted = numbers.OrderByDescending(x => x).ToArray();
            int count = numbers.Length >= 3 ? 3 : numbers.Length;//top 3 numbers

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

        }
    }
}
