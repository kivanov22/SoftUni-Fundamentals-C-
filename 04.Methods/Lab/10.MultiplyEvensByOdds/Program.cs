using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers =Math.Abs(int.Parse(Console.ReadLine()));
            
            //GetSumOfEvenDigits(numbers);
            //GetSumOfOddDigits(numbers);
            int result =GetMultipleOfEvenAndOdds(numbers);
            Console.WriteLine(result);
        }

        private static int GetSumOfOddDigits(int numbers)//odd sum
        {
            int sumOdd = 0;//sum of odds

            while (numbers!=0)
            {
                int nextSumOdd = numbers % 10;//take last digit and check it for odd

                if (nextSumOdd%2==1)//check for odd
                {
                    sumOdd += nextSumOdd;//add to sum the number
                }
                numbers -= nextSumOdd; //make the checked digit a zero
                numbers /= 10;//remove from numbers the checked number
            }
            return sumOdd;//return to the first method
        }

        private static int GetSumOfEvenDigits(int numbers)//even sum
        {
            int sumEven = 0;

            while (numbers !=0)
            {
                int nextSum = numbers % 10;

                if (nextSum%2==0)
                {
                    sumEven += nextSum;
                }
                numbers -= nextSum;
                numbers /= 10;
            }
            return sumEven;
        }

        private static int GetMultipleOfEvenAndOdds(int numbers)//Multiply
        {
            int total = GetSumOfEvenDigits(numbers) * GetSumOfOddDigits(numbers);
            return total;
        }
    }
}
//•	Create a method called GetMultipleOfEvenAndOdds()
//•	Create a method GetSumOfEvenDigits()
//•	Create GetSumOfOddDigits()
//•	You may need to use Math.Abs() for negative numbers
