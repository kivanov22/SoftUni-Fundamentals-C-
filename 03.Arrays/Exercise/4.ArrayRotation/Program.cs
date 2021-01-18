using System;

namespace _4.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) //number times that we have to rotate numbers
            {
                string elementRotate = arr[0];

                for (int j = 1; j < arr.Length; j++)// array cycle and start from next element
                {
                    string currentElement = arr[j];// take current element
                    arr[j - 1] = currentElement;//take the array , we take the next element switch second element to first
                }
                arr[arr.Length - 1] = elementRotate;//take element which we rotate from elementRotate
            }
            Console.WriteLine(string.Join(" ",arr));//separator after join (" ")
        }
    }
}
