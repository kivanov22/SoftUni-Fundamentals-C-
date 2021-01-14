using System;
using System.Linq;

namespace _5.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array to store the numbers
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;//prazna promenliva da suhranqva sumata

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];//promenliva skladirashta chislata

                if (currentNumber%2==0)//proverka dali e chetno
                {
                    sum += currentNumber;//dobavqme chetnoto v sumata 
                }

            }
            Console.WriteLine(sum);//printirame sumata na chetnite
        }
    }
}
