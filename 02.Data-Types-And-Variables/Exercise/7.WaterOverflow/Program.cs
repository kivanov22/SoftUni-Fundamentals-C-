using System;

namespace _7.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int litters = int.Parse(Console.ReadLine());

               

                bool isFull = litters > 255; //proverki
                bool overFlow = sum + litters> 255;

                if (isFull || overFlow)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                sum += litters;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
