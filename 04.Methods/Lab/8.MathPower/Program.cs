using System;

namespace _8.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }


        static double RaiseToPower(double number,double power)
        {
            double result = 0d;

           result= Math.Pow(number, power);


            return result;
        }
    }
}
