using System;
using System.Linq;

namespace _3.ZigZagPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];//empty in arrays
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
               int[] currentLine= Console.ReadLine().Split().Select(int.Parse).ToArray();// we get from console numbers from string to int

                if (i % 2 ==0)//check if even or odd
                {
                    arr1[i] = currentLine[0];//take first element in arr1
                    arr2[i] = currentLine[1];//take second element in arr2
                }
                else//swap the elements in the array we get from console
                {
                    arr1[i] = currentLine[1];//take the second element in arr1
                    arr2[i] = currentLine[0];//take the first element in arr2
                }

            }
            Console.WriteLine(string.Join(' ', arr1));//print arrays with space
            Console.WriteLine(string.Join(' ', arr2));
        }
    }
}
