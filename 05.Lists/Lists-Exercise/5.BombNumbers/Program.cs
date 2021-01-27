using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombExplosion = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombExplosion[0];
            int power = bombExplosion[1];

            for (int i = 0; i < numbers.Count; i++)
            {

                int currentNumber = numbers[i];

                if (currentNumber == bomb)
                {
                    int startIndex = i - power;//bomb - power from left 2 numbers remove
                    int endIndex = i + power;// this take after bomb number 2 numbers which detonate

                    if (startIndex<0)// with this we guarantee we don't go out of the array from left 
                    {
                        startIndex = 0;// if less than 0 we set it to 0
                    }
                    if (endIndex>numbers.Count-1)// if more than last index
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1;//end index from which we will remove elements , count
                    numbers.RemoveRange(startIndex, endIndexToRemove);//how much elements we want to remove

                    i = startIndex - 1;//so we dont mess indexes in for loop, when we remove numbers from loop it won't say to us index out of range
                }

            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
