using System;
using System.Collections.Generic;

namespace _4.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();//empty list

            for (int i = 0; i < n; i++)//iterrate n times
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);//add currentProduct to productList
            }
            products.Sort();//sort alpha

            for (int j = 0; j < products.Count; j++)
            {
                Console.WriteLine($"{j+1}.{products[j]}");
            }
        }
    }
}
