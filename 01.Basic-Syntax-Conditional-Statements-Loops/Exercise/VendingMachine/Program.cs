using System;

namespace _7.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();

            double totalCoins = 0;

            while (coins !="Start")
            {

                double coinAmount = double.Parse(coins);


                //bool isValidMoney = coinsAmount ==0.1|| define the condition

                if (coinAmount==0.1 || coinAmount==0.2 ||coinAmount==0.5 || coinAmount==1 || coinAmount==2)
                {
                    totalCoins += coinAmount;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinAmount}");
                }


                coins = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                double productPrice = 0;

                switch (product)
                {
                    //2.0, 0.7, 1.5, 0.8, 1.0 
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                        case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }

                                  

                if (productPrice<=totalCoins)
                {
                    totalCoins -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}
