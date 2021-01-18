using System;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];//array taking n from console
            int sum = 0;

            for (int i = 0; i < wagons.Length; i++)//array length 
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            Console.WriteLine(string.Join(" " ,wagons));
            Console.WriteLine(sum);
            //Console.WriteLine(wagons.Sum()); Linq method
        }
    }
}
