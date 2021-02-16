using System;

namespace _1.World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
           //.Split(new[] { ':', '-', ' ' },StringSplitOptions.RemoveEmptyEntries);

            string command = Console.ReadLine();

            while (command!="Travel")
            {
                string[] cmdArgs = command.Split(":");
                string action = cmdArgs[0];
               

                if (action=="Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string text = cmdArgs[2];

                    if (index>=0 && index<stops.Length)
                    {
                        stops = stops.Insert(index, text);
                        
                    }
                    Console.WriteLine(stops);
                }
                else if (action=="Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    //problem here check after
                    if (startIndex >=0 && endIndex<stops.Length)
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex+1);
                        
                    }
                    Console.WriteLine(stops);
                }
                else if (action=="Switch")
                {
                    string old = cmdArgs[1];
                    string newString = cmdArgs[2];

                    if (stops.Contains(old))
                    {
                      stops=  stops.Replace(old, newString);
                        
                    }
                    Console.WriteLine(stops);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
