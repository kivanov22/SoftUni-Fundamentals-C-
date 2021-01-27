using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string message = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int index = CalculateIndex(currentNumber);

                char currentChar = GetCharFromMessage(index, message);
                Console.Write(currentChar);
            }
        }

        private static char GetCharFromMessage(int index, string message)
        {
            
        }

        public static int CalculateIndex(int number)
        {
            int index = 0;
            while (number>0)
            {
                int currentNumber = number % 10;
                index += currentNumber;
                number /= 10;
            }
            return index;
        }

    }
}
