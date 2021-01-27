using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();//firstList
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();//secondList 

            List<int> resultList = new List<int>();//empty list to get the result from both

            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)//iterate through the smaller one
            {
                resultList.Add(firstList[i]);//adding numbers from firstList index to resultList
                resultList.Add(secondList[i]);//adding numbers from secondList index to resultList


            }

            for (int i = Math.Min(firstList.Count, secondList.Count); i < Math.Max(firstList.Count,secondList.Count); i++)//check little list vs bigger
            {
                if (i>=firstList.Count)//check if index i is bigger or equal to firsLists
                {
                    resultList.Add(secondList[i]);
                }
                else
                {
                    resultList.Add(firstList[i]);
                }
            }
            Console.WriteLine(string.Join(" ",resultList));
        }

        }
    }

