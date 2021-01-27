using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int originalLength = numbers.Count;

            for (int i = 0; i < originalLength/2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];// we sum first element with last element in the list
                numbers.RemoveAt(numbers.Count - 1);// after we sum first and last , we remove the last element so we can make the next sum pairs
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
