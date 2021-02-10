using System;

namespace Honey_Winter_Reserves
{
    class Program
    {
        static void Main(string[] args)
        {

            //6-ta zadacha
            double amountHoney = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double total = 0;
            bool yes = false;
            double banished = 0;
            
            while (input != "Winter has come")
            {
                 for (int month = 1; month <= 6; month++)
                {
                    double honeyHarvest = double.Parse(Console.ReadLine());
                    
                        total += honeyHarvest;
                        banished +=honeyHarvest;
                        //total += banished;
                       // total += honeyHarvest;
                    }
                    //total += banished;
                    
                   if (banished < 0)
                {
                    Console.WriteLine($"{input} was banished for gluttony");
                    
                }

                if (total >= amountHoney)
                {
                    Console.WriteLine($"Well done! Honey surplus {total - amountHoney:f2}.");
                    yes = true;
                break;
                }
                input = Console.ReadLine();
                }
                if (!yes)
            {
                Console.WriteLine($"Hard Winter! Honey needed {amountHoney - total:f2}.");
                
            }
                

        }
            

        }
    }
