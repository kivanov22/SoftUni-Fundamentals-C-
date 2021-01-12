using System;

namespace _4.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string isPrime = "";
            for (int i = 2; i <= number; i++)
            {
                //bool isPrime = true;
                isPrime = "true";

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        //isPrime = false;
                        isPrime = "false";
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
