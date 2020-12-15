using System;

namespace Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }




            //if(country=="USA" && country == "England")
            //{
            //    Console.WriteLine("English");
            //}
            //if(country=="Spain" && country == "Argentina" && country == "Mexico")
            //{
            //    Console.WriteLine("Spanish");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown");
            //}
        }
    }
}
