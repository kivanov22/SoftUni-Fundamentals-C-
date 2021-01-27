using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = Console.ReadLine().Split().Select(int.Parse).ToList();


            string command = Console.ReadLine();

            while (command !="end")
            {
                string[] cmArg = command.Split();

                string firstCommand = cmArg[0];//delete and insert
                int element = int.Parse(cmArg[1]);//element

                if (firstCommand=="Delete")
                {
                    listOfInt.RemoveAll(x=>x==element);
                }
                else if (firstCommand=="Insert")//
                {
                    int index = int.Parse(cmArg[2]);
                    listOfInt.Insert(index, element);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listOfInt));
        }
    }
}
