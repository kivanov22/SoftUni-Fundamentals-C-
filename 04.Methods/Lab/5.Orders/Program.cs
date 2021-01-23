using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            PrintProducts(product, amount);

        }


        static void PrintProducts(string product,double amount)
        {
            double price = 0;
            double sum = 0;

            switch (product)
            {
                case "water":
                    price = 1.00;
                    break;
                case "coffee":
                    price = 1.50;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                
            }
            sum = price*amount;
            Console.WriteLine($"{sum:f2}");
            
        }
    }
}
