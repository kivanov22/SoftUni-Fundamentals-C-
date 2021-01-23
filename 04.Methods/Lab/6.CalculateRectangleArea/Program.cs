using System;

namespace _6.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, height);// we created a variable for storing the method, so we can access the new value
            Console.WriteLine(area);
        }


        static double GetRectangleArea(double width , double height)//double instead of void 
        {
            return width * height;//return so we can pass this to the first method
        }
    }
}
