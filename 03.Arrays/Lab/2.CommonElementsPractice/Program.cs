using System;

namespace _2.CommonElementsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();//arrays
            string[] array2 = Console.ReadLine().Split();

            for (int i = 0; i < array2.Length; i++)//going through the second array
            {
                for (int j = 0; j < array1.Length; j++)//going through the first array
                {
                       if (array1[j]==array2[i])//checking if there is element from second array in first array and print
                    {
                        Console.Write(array2[i] + " ");
                    }
                }


            }

        }
    }
}
