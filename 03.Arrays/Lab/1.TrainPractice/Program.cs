using System;
using System.Linq;

namespace _1.TrainPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];//empty array
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());//directly giving the numbers in the empty array
                 sum = wagons.Sum();//summing the numbers in the arrray
            }
            Console.WriteLine(String.Join(' ',wagons));//print the array with space
            Console.WriteLine(sum);
        }
    }
}
