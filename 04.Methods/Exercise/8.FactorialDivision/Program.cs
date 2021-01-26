using System;

namespace _8.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double firstFactorial = GetFactorial(num1);
            double secondFactorial = GetFactorial(num2);
            double result = firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
        }

        private static double GetFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
//double result = 1;
//while (number != 1)
//{
//    result = result * number;
//    number = number - 1;
//}
////return result;