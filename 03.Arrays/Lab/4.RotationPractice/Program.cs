using System;
using System.Linq;

namespace _4.RotationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRotation = Console.ReadLine().Split().Select(int.Parse).ToArray();//we take array from console

            int n = int.Parse(Console.ReadLine());//rotations for places of numbers

            //51 47 32 61 21
            // 2


            for (int i = 0; i < n; i++)//2 times
            {
                int firstElement = arrayRotation[0];//32
                int[] temp = new int[arrayRotation.Length];//empty temporary array that has exactly how much numbers we got in the array from console
                //61 21
                for (int j = 1; j < arrayRotation.Length; j++)//going through the array 51 47 32 61 21
                {
                    temp[j - 1] = arrayRotation[j];// 0 position to get first position from array 47 replace 51
                }
                temp[temp.Length - 1] = firstElement;//51 goes to last position index=4
                arrayRotation = temp;//takes the new array temp positions so it doesn't show old placing
            }
        }
    }
}
