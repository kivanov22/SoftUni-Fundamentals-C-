using System;

namespace _2.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //   X1, Y1, X2 and Y2
            //coordinate system(0, 0) in the format(X, Y). If the points are on a same distance from the center, print only the first one.

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintsClosestToTheCenterPoints(x1, y1, x2, y2);
            
        }

        private static void PrintsClosestToTheCenterPoints(double x1, double y1, double x2, double y2)
        {
            double result1 = Math.Sqrt(Math.Pow((x1), 2) + Math.Pow((y1), 2));
            double result2 = Math.Sqrt(Math.Pow((x2), 2) + Math.Pow((y2), 2));

            if (result1 < result2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
