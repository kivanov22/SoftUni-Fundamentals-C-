using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokeDistance = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();//input from console 


            int sum = 0;

            while (pokeDistance.Count > 0)//loop till no items in the list
            {
                int indexToRemove = int.Parse(Console.ReadLine());//index from console which we need to remove from list
                                                                  // int index = indexToRemove[0];

                int element = 0;

                if (indexToRemove < 0)
                {
                    element = pokeDistance[0];
                    pokeDistance[0] = pokeDistance[pokeDistance.Count - 1];

                }
                else if (indexToRemove >= pokeDistance.Count)
                {
                    element = pokeDistance[pokeDistance.Count - 1];
                    pokeDistance[pokeDistance.Count - 1] = pokeDistance[0];
                }
                else
                {
                    element = pokeDistance[indexToRemove];
                    pokeDistance.RemoveAt(indexToRemove);//we delete the index element from list
                }
                sum += element;

                for (int i = 0; i < pokeDistance.Count; i++)
                {
                    if (pokeDistance[i] <= element)
                    {
                        pokeDistance[i] += element;
                    }
                    else
                    {
                        pokeDistance[i] -= element;
                    }
                }

            }

            Console.WriteLine(sum);
        }




    }
}


