using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                                            .Split()
                                            .Select(double.Parse)
                                            .ToList();
            
            int n = 0;
            while (n < numbers.Count - 1)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (numbers[n] == numbers[n + 1])
                    {
                        double sum = numbers[n] + numbers[n + 1];
                        numbers[n] = sum;
                        numbers.Remove(numbers[n + 1]);
                        n = 0;
                    }
                    else
                    {
                        n++;
                        break;

                    }

                }
                
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
