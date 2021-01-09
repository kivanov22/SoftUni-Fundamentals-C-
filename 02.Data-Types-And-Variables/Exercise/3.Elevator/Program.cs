using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int count = 0;

            while (number>0)
            {
                
                number -= capacity;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
