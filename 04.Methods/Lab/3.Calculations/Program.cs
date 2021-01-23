using System;
using System.ComponentModel;

namespace _3.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            //add, multiply, subtract, divide

            switch (action)
            {
                case "add":
                    Add(number1, number2);
                    break;
                case "subtract":
                    Subtract(number1, number2);
                    break;
                case "multiply":
                    Multiply(number1, number2);
                    break;
                case "divide":
                    Divide(number1, number2);
                    break;
                
            }
        }

        // 4 methods for the 4 actions 
        static void Add(int number1 , int number2)
        {
            Console.WriteLine(number1+number2);
        }

        static void Subtract(int number1 , int number2)
        {
            Console.WriteLine(number1-number2);
        }
        static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1*number2);
        }
        static void Divide (int number1 , int number2)
        {
            Console.WriteLine(number1/number2);
        }
    }
}
