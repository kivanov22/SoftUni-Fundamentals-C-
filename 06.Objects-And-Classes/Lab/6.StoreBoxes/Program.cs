using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _6.StoreBoxes
{
    class Program
    {
        class Item
        {
            public string Name { get; set; }

            public double Price { get; set; }
        }
        class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public string SerialNumber { get; set; }

            public Item Item { get; set; }

            public int Quantity { get; set; }

            public double PriceBox { get; set; }

        }
        static void Main(string[] args)
        {
            List<Box> storeBoxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input.Split(" ");

                string serial = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                double priceBox = itemQuantity * itemPrice;

                Box boxes = new Box();
                Item items = new Item();

                items.Name = itemName;
                items.Price = itemPrice;

                boxes.SerialNumber = serial;
                boxes.Quantity = itemQuantity;
                boxes.PriceBox = priceBox;




                input = Console.ReadLine();
            }


                




            }
        }
    }
