using System;
using System.Collections.Generic;

namespace _4.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input!="buy")
            {
                string[] currentProduct = input.Split();
                string productName = currentProduct[0];
                double productPrice =double.Parse(currentProduct[1]);
                int productQuantity = int.Parse(currentProduct[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new List<double> { productPrice, productQuantity });
                }
                else
                {
                    products[productName][0] = productPrice;//index 0 is productPrice/index 1 is ProductQuantity
                    products[productName][1] += productQuantity;//we set the index because we can't take double to list
                    
                }

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                double total = item.Value[0] * item.Value[1];//find total from the new list by indexes

                Console.WriteLine($"{item.Key} -> {total:f2}");
            }
        }
    }
}
