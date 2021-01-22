using System;

namespace _7._MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int bestCount = 0;
            int bestIndex = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                string currentElement = arr[i];
                int currentCounter = 1;


                for (int j =i + 1; j < arr.Length; j++)//check elements , we go through the other part of the cycle i+1
                {
                    if (currentElement == arr[j])// we check if current element == to the next element
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentCounter > bestCount)
                {
                    bestCount = currentCounter;
                    bestIndex = i;// i is the index from which we start
                }

            }

            for (int i = 0; i < bestCount; i++)//cycle through the numbers in bestCount
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
