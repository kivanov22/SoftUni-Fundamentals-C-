using System;

namespace _5.AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = PrintSum(first, second, third);
            Console.WriteLine(sum);
        }

        static int PrintSum(int first,int second,int third)//summing numbers and returning method for Substract 
        {
            int sumBothNumbers = first+second;
            return Substract(sumBothNumbers, third);
        }

        private static int Substract(int sumBothNumbers, int third)//Substract method giving the value to PrintSum
        {
            return sumBothNumbers - third;
        }
    }
}
