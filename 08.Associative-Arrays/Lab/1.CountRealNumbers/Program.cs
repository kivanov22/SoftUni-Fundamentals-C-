using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))//we check if the dictionary contains number
                {
                    counts[number]++;//we increase count inside the dictionary
                }
                else
                {
                    counts.Add(number, 1);//we add the number and the count
                }
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
