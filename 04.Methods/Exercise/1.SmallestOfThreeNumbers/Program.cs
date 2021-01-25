using System;

namespace _1.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            SmallestNumber(num1, num2, num3);

        }

        static void SmallestNumber(double num1 , double num2, double num3)
        {
            if (num1<num2&&num1<num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2<num1 && num2<num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3<num1 && num3<num2)
            {
                Console.WriteLine(num3);
            }
        }

    }
}
