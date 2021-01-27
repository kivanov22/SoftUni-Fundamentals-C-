using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _4.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input !="End")
            {
                string[] cmdArg = input.Split(" ");

                string command = cmdArg[0];//•	Add {number} -- Add is on 0 index and number is on 1 index
                

                if (command == "Add")//Add
                {
                    int element = int.Parse(cmdArg[1]);
                    numbers.Add(element);
                }
                else if (command == "Insert")//Insert
                {
                    int number = int.Parse(cmdArg[1]);
                    int index = int.Parse(cmdArg[2]);

                    if (isValidIndex(index,numbers.Count))//method for checking valid or not index
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (command == "Remove")// Remove we use if isValidIndex only on commands with indexes
                {
                    int index = int.Parse(cmdArg[1]);
                   

                    if (isValidIndex(index, numbers.Count))//method for checking valid or not index
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command == "Shift")
                {
                    int rotation = int.Parse(cmdArg[2]);//the given number to rotate

                    if (cmdArg[1]=="left")//rotating list to the left 
                    {
                        for (int i = 0; i < rotation; i++)// for loop how much we want to rotate
                        {
                            int firstElement = numbers[0];//we save our first element because it will go at the end
                            //numbers[0] - numbers is our list and [0] is first element
                            for (int j = 0; j < numbers.Count-1; j++)// we iterate till the end of the list "-1"
                            {
                                numbers[j] = numbers[j + 1];//we move it with one index forward so it will save from second number instead of first
                                //we swap numbers numbers[j] the current index and we set it to the previous
                            }
                            numbers[numbers.Count - 1] = firstElement;//we take the last index and we set it to firstElement 1,2,3,4 we take 4 and set it to 1
                        }

                    }
                    //right

                    else
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int lastElement = numbers[numbers.Count - 1];// we take the last element numbers[numbers.Count-1]

                            for (int j = numbers.Count - 1; j > 0; j--)//without =
                            {
                                numbers[j] = numbers[j - 1];//same as left but we rotate to right thats why we set to j - 1
                            }
                            numbers[0] = lastElement;//first number we set to last element
                        }

                    }
                }
      
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static bool isValidIndex(int index,int count)//method of validation of index and its good cause we reuse the code 
        {
            //if index > count which is the list elements and cant be less then 0
            return index > count || index < 0;
        }
    }
}
