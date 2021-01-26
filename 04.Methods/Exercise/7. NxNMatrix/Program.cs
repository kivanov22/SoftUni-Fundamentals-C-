using System;

namespace _7._NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);// we dont need anything to return only print from console
        }

        private static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)//two loops for numbers
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n +" ");//print n with space
                }
                Console.WriteLine();//extra line
            }
        }
    }
}
