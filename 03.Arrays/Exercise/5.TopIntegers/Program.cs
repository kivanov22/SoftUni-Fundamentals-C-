using System;
using System.Linq;

namespace _5.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();//array of integers, can be done with strings too

            bool isBigger = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentInt = arr[i];

                for (int j = i+1; j < arr.Length; j++)//compare to the next number instead of the first i+1
                {
                    if (arr[j]>=currentInt)//check if the number is bigger than the others
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(currentInt + " ");//print with space
                }

                isBigger = true;//set to true , because the inner for check we set it to false
            }
        }
    }
}
