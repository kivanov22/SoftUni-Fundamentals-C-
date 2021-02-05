using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> targets = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] targets = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            //see the element in collection how to divede
            //and if index is valid 
            int countShots = 0;

            while (input!="End")
            {
                int index = int.Parse(input);

                if (index < 0 || index >= targets.Length ||targets[index]==-1)//valid index check, condition for -1 target
                {
                    input = Console.ReadLine();
                    continue;
                }
                int shotTarget = targets[index];
                targets[index]= - 1;
                countShots++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i]==-1)
                    {
                        continue;//next element in for loop
                    }
                    if (targets[i]>shotTarget)
                    {
                        targets[i] -= shotTarget;
                    }
                    else
                    {
                        targets[i] += shotTarget;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {countShots} -> {string.Join(" ",targets)}");
        }
    }
}
