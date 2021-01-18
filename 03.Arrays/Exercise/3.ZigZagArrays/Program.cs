using System;
using System.Linq;

namespace _3.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr1 = new string[n]; // string array because we won't use any calculations.
            string[] arr2 = new string[n];


            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine().Split(" ").ToArray();//poluchavame ot konzolata

                string firstNumber = currentArray[0];//taking index
                string secondNumber = currentArray[1];

                if (i%2==0)//even itteration
                {
                    arr1[i] = firstNumber;//change where index goes to which array
                    arr2[i] = secondNumber;
                }
                else if (i % 2 == 1)//odd iterration
                {
                    arr1[i] = secondNumber; //opossite 
                    arr2[i] = firstNumber;
                }

            }
            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
