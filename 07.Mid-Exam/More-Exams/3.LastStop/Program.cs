using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input!="END")
            {
                string[] commands = input.Split(" ");

                switch (commands[0])
                {
                    case "Change":
                        int paintingNumber = int.Parse(commands[1]);
                        int changedNumber = int.Parse(commands[2]);

                        if (numbers.Contains(paintingNumber))
                        {
                            int indexNumber = numbers.FindIndex(x => x == paintingNumber);
                            //int indexChangeNumber = numbers.FindIndex(x => x == changedNumber);

                            //int currentNumber = numbers[indexNumber];
                            numbers[indexNumber] = changedNumber;

                        }
                        break;
                    case "Hide":
                        int hidePainting = int.Parse(commands[1]);

                        if (numbers.Contains(hidePainting))
                        {
                            numbers.Remove(hidePainting);
                        }
                        break;
                    case "Switch":
                        int paintingNumber1 = int.Parse(commands[1]);
                        int paintingNumber2 = int.Parse(commands[2]);

                        if (numbers.Contains(paintingNumber1) && numbers.Contains(paintingNumber2))
                        {
                         int indexNumber1= numbers.FindIndex(x => x ==paintingNumber1);
                         int indexNumber2 = numbers.FindIndex(x => x == paintingNumber2);

                            int swapNumbers = numbers[indexNumber1];
                            numbers[indexNumber1] =numbers[indexNumber2];
                            numbers[indexNumber2] = swapNumbers;
                        }
                        break;
                    case "Insert":
                        int placeIndex = int.Parse(commands[1]);
                        int paintingInsert = int.Parse(commands[2]);

                        if (placeIndex< numbers.Count && placeIndex>=0)//&& numbers.Contains(paintingInsert//numbers.Contains(numbers[placeIndex])
                        {
                            numbers.Insert(placeIndex + 1,paintingInsert);
                        }
                        break;
                    case "Reverse":
                        numbers.Reverse();
                        break;
                    
                }
                input = Console.ReadLine();
                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
