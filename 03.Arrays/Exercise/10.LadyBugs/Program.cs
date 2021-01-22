using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());//we take an array

            int[] indexesOfLadybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arr = new int[sizeOfField];


            for (int i = 0; i < arr.Length; i++)
            {
                if (indexesOfLadybugs.Contains(i))
                {
                    arr[i] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandToArray = command.Split();
                int index = int.Parse(commandToArray[0]);
                string direction = commandToArray[1];
                int range = int.Parse(commandToArray[2]);

                if (index >= 0 && (index < sizeOfField) && (arr[index] == 1))
                {
                    arr[index] = 0;

                    if (direction == "right")
                    {
                        while ((index + range < sizeOfField) && (index + range >= 0))
                        {
                            if (arr[index + range] == 0)
                            {
                                arr[index + range] = 1;
                                break;
                            }
                            else index += range;
                        }
                    }
                    else if (direction == "left")
                    {
                        while ((index - range >= 0) && (index - range < sizeOfField))
                        {
                            if (arr[index - range] == 0)
                            {
                                arr[index - range] = 1;
                                break;
                            }
                            else index -= range;
                        }
                    }
                    else arr[index] = 1;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

