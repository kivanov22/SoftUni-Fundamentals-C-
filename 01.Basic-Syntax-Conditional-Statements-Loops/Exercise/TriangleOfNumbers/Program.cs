using System;

namespace _8.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
