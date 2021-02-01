using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();



            List<int> greaterNumbers = new List<int>();

            greaterNumbers = numbers.Where(x => x > numbers.Average()).ToList();
            if (greaterNumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            Console.WriteLine(string.Join(" ", greaterNumbers.OrderByDescending(x => x).Take(Math.Min(5, greaterNumbers.Count))));
        }
    }
}
//List<int> sequenceIntegers = Console
//                       .ReadLine()
//                       .Split()
//                       .Select(int.Parse)
//                       .ToList();

//var result = sequenceIntegers.Where(x => x > sequenceIntegers.Average()).ToList();

//if (result.Count == 0)
//{
//    Console.WriteLine("No");
//    return;
//}

//Console.WriteLine(string.Join(" ", result.OrderByDescending(x => x).Take(Math.Min(5, result.Count))));