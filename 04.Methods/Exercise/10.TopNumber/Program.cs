using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopNumber(number);//first method
        }

        private static void PrintTopNumber(int number)//method for printing top number , and a loop for the numbers
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDigitSumDivisible(i)&&HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        //because the methods are for checking if the conditions is true they are bool
        private static bool HasOddDigit(int number)// method for finding odd number
        {
            while (number>0)
            {
                if ((number%10)%2==1)
                {
                    return true;
                   
                }
                number /= 10;
            }
            return false;
        }

        private static bool IsDigitSumDivisible(int number)//method for finding digit sum and checking divisible to 8
        {
            int digitSum = 0;

            while (number>0)
            {
                digitSum += number % 10;
                number /= 10;
            }
            if (digitSum%8==0)
            {
                return true;
            }
            return false;
        }


    }
}
