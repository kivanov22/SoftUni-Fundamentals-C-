using System;
using System.Linq;

namespace _6.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
          

            bool isFound = false;

            for (int current = 0; current < arr.Length; current++)//current number
            {
                int sumRight = 0;//inside the for cycle so every itteration the summ will reset to 0
                

                for (int i = current+1; i <arr.Length; i++)//from next element to forward, from left to right.-->
                {
                    sumRight += arr[i]; //for rightsum finding
                }

                //both for cycles with i -index , forr too so it will take both sides.And meet in middle
                int sumLeft = 0;

                for (int i = current - 1; i >= 0; i--)//for leftsum finding forr from right to left.<--
                {
                    sumLeft += arr[i];
                }
                if (sumRight==sumLeft)//check if left/right sums are equal
                {
                    Console.WriteLine(current);//print index not number
                    isFound = true;
                    break;
                }
            }
            if (!isFound)//denial ! false=true;
            {
                Console.WriteLine("no");
            }
        }
    }
}
