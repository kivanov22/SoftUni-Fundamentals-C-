using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
             double length = double.Parse(Console.ReadLine());

            
            double width = double.Parse(Console.ReadLine());

            
           double heigth = double.Parse(Console.ReadLine());

            double total = length*width*heigth/3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {total:f2}");

        }
    }
}
