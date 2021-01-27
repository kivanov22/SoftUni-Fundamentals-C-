using System;

namespace _5._MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            FindProduct(num1, num2, num3);
        }

        private static void FindProduct(double num1, double num2, double num3)
        {
            
            if (num1==0 || num2==0 || num3==0)
            {
                Console.WriteLine("zero");
            }
           else if ((num1 > 0 && num2 > 0 && num3 > 0) ||
                 (num1 < 0 && num2 < 0 && num3 > 0) ||
                 (num1 < 0 && num2 > 0 && num3 < 0) ||
                 (num1 > 0 && num2 < 0 && num3 < 0))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
           
        }
    }
}
//another option for this taks is with for