using System;

namespace _1.CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            double orderPrice = 0;
            double total = 0;
            for (int i = 0; i < countOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                 orderPrice = (days * capsulesCount) * pricePerCapsule;
                total += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
