using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.RemoveAll(n => n < 0);//removing negatives


            //List<int> result = numbers.Where(n => n >= 0).Reverse().ToList(); another way to do it less code and we go directly to if-else

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<0)
                {
                    numbers.RemoveAt(i--);
                }
            }
            numbers.Reverse();//we need a for loop for reverse and a count

            if (numbers.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
