using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            

            bool isSpecial = false;
            int special = 0;
            for (int i = 1; i <= number; i++)
            {
                special = i;
                int sum = 0;
               

                while (i > 0)
                {
                    sum += special % 10;
                    special = special / 10;
                }
                isSpecial = sum == 5 || sum == 7 || sum == 11;

                sum = 0;
                if (isSpecial)
                {
                    Console.WriteLine("{0} -> {1}", special, isSpecial);
                }
                
            }
            
        }
        }
}
