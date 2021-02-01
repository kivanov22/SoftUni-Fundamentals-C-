using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ");
                string command = tokens[0];
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);//value diff in diff cases

                if (index < 0 || index >= targets.Count)//invalid index check
                {
                    if (command == "Add")
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                    else if (command == "Strike")
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                    continue;
                }
                switch (command)
                {
                    case "Shoot":
                        targets[index] -= value;//we decrease valie of

                        if (targets[index] <= 0)//check after we decrease the value
                        {
                            targets.RemoveAt(index);//we remove element
                        }
                        break;
                    case "Add":
                        targets.Insert(index, value);//+1 -1 for forward /backward
                        break;
                    case "Strike":
                        if (index - value < 0 || index + value >= targets.Count)
                        {
                            Console.WriteLine($"Strike missed!");
                            continue;
                        }
                        //try with range or where
                        //for (int i = index - value; i <= index + value; i++)
                        //{
                        //    targets.RemoveAt(index-value);
                        //}
                        targets.RemoveRange(index-value,(value*2)+1);
                        break;
                }
            }
            Console.WriteLine(string.Join("|",targets));
        }
    }
}
//can use a method for valid index