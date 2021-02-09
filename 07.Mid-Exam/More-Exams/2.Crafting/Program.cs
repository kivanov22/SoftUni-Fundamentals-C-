using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partsWeapon = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            //string[] partsWeapon = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToArray();
            string input = Console.ReadLine();
            List<string> newList = new List<string>();
            while (input != "Done")
            {
                string[] commands = input.Split();
                string direction = commands[1];


                switch (direction)
                {
                    case "Left":

                        int indexLeft = int.Parse(commands[2]);
                        if (indexLeft > 0 && indexLeft < partsWeapon.Count)
                        {
                            string currentLeftElement = partsWeapon[indexLeft - 1];
                            partsWeapon[indexLeft - 1] = partsWeapon[indexLeft];
                            partsWeapon[indexLeft] = currentLeftElement;
                        }

                        break;
                    case "Right":
                        int indexRight = int.Parse(commands[2]);
                        if (indexRight >= 0 && indexRight < partsWeapon.Count - 1)
                        {
                            string currentElement = partsWeapon[indexRight + 1];
                            partsWeapon[indexRight + 1] = partsWeapon[indexRight];
                            partsWeapon[indexRight] = currentElement;
                        }
                        break;
                    case "Even":
                        for (int i = 0; i < partsWeapon.Count; i++)
                        {
                            string currentElementEven = partsWeapon[i];

                            if (i % 2 == 0)
                            {
                                newList.Add(currentElementEven);

                            }
                        }
                        break;
                    case "Odd":
                        for (int j = 1; j < partsWeapon.Count; j++)
                        {
                            string currentElementOdd = partsWeapon[j];

                            if (j % 2 != 0)
                            {
                                newList.Add(currentElementOdd);
                            }
                        }

                        break;
                }
                input = Console.ReadLine();
            }
            StringBuilder sb = new StringBuilder();
            foreach (var items in newList)
            {
                sb.Append($"{items}" + " ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());

            Console.WriteLine($"You crafted " + string.Join("", partsWeapon) + "!");
        }
    }
}
