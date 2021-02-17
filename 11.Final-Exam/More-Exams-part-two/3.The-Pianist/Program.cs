using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            var pieceAndComposers = new Dictionary<string, string>();
            var pieceAndKeys = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] pieces = Console.ReadLine().Split("|");
                string name = pieces[0];
                string composerName = pieces[1];
                string major = pieces[2];

                pieceAndComposers[name] = composerName;
                pieceAndKeys[name] = major;


            }
            string command = Console.ReadLine();

            while (command!="Stop")
            {
                string[] cmdArgs = command.Split("|");
                string action = cmdArgs[0];
                string piece = cmdArgs[1];


                if (action=="Add")
                {
                    string composerName = cmdArgs[2];
                    string major = cmdArgs[3];

                    if (pieceAndComposers.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pieceAndComposers.Add(piece,composerName);//mistake keys[composerName] = piece instead of add
                                                                 
                        pieceAndKeys.Add(piece,major);
                        Console.WriteLine($"{piece} by {composerName} in {major} added to the collection!");
                    }
                }
                else if (action=="Remove")
                {
                    if (pieceAndComposers.ContainsKey(piece))
                    {
                        pieceAndComposers.Remove(piece);
                        pieceAndKeys.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }
                else if (action== "ChangeKey")
                {
                    string key = cmdArgs[2];

                    if (pieceAndKeys.ContainsKey(piece))
                    {
                        pieceAndKeys[piece] = key;
                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                
                command = Console.ReadLine();
            }
            foreach (var item in pieceAndComposers.OrderBy(x=>x.Key).ThenBy(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value}, Key: {pieceAndKeys[item.Key]}");
            }
        }
    }
}
