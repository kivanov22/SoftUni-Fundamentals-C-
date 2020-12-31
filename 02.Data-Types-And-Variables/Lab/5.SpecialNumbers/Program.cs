using System;

namespace _5.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool check = false;
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;

                while (digits>0)
                {

                    sumOfDigits += digits % 10;
                    digits = digits / 10;


                    
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                sumOfDigits = 0;
                Console.WriteLine($"{i} -> {check}");
            }
            

        }
    }
}
