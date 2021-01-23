using System;

namespace _4.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);// we call the method for the triangle


        }

        static void PrintLine(int start, int end)//method for printing numbers from start to end
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


        static void PrintTriangle(int n)//method for Triangle
        {
            for (int line = 1; line <=n; line++)
            {
                PrintLine(1, line);
              
            }



            for (int line= n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
                
            }
        }
    }
}
