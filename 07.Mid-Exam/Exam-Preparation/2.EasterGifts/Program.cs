using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Sources;

namespace _2.EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
         List<string>giftsCollection = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] command = input.Split();
                string action = command[0];
                string gift = command[1];
                string setValue = "None";

                if (command[0]== "OutOfStock")
                {
                    if (giftsCollection.Contains(gift))
                    {
                        for (int i = 0; i < giftsCollection.Count; i++)
                        {
                            if (giftsCollection[i]==gift)
                            {
                                giftsCollection[i] = setValue;
                            }
                        }
                       
                        
                    }

                }
                else if (command[0]== "Required")
                {
                    int index =int.Parse(command[2]);
                    if (index >= 0 && index < giftsCollection.Count)
                    {
                        giftsCollection[index] = gift;
                        //giftsCollection.RemoveAt(index);
                        //giftsCollection.Insert(index, gift);

                    }
                }
                else if (command[0]== "JustInCase")
                {
                    giftsCollection.RemoveAt(giftsCollection.Count - 1);
                    giftsCollection.Add(gift);
                }


                input = Console.ReadLine();
            }
            giftsCollection.RemoveAll(x => x == "None");
            Console.WriteLine(string.Join(" ",giftsCollection));
        }
    }
}
