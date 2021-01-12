using System;

namespace _3.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double precision = 0.000001;

            if (a<b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            if (a-b<precision)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
