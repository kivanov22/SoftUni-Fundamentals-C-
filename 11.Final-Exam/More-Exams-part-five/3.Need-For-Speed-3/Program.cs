using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Need_For_Speed_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var mileage = new Dictionary<string, int>();
            var fuel = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            int carTank = 75;
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split("|");
                //{car}|{mileage}|{fuel}
                string modelName = cmdArgs[0];
                int mil = int.Parse(cmdArgs[1]);
                int gas = int.Parse(cmdArgs[2]);

                mileage[modelName] = mil;
                fuel[modelName] = gas;

            }
            string command = Console.ReadLine();

            while (command!="Stop")
            {
                string[] cmdArg = command.Split(" : ");
                string action = cmdArg[0];
                string carModel = cmdArg[1];

                if (action=="Drive")
                {
                    int distance = int.Parse(cmdArg[2]);
                    int fil = int.Parse(cmdArg[3]);

                    if (fuel[carModel]>=fil)
                    {
                        mileage[carModel] += distance;
                        fuel[carModel] -= fil;
                        Console.WriteLine($"{carModel} driven for {distance} kilometers. {fil} liters of fuel consumed.");

                        if (mileage[carModel]>100000)
                        {
                            Console.WriteLine($"Time to sell the {carModel}!");
                            mileage.Remove(carModel);
                            fuel.Remove(carModel);
                        }
                    }
                     else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (action=="Refuel")
                {
                    int fil = int.Parse(cmdArg[2]);
                    int fuelBefore = fuel[carModel];
                    fuel[carModel] += fil;

                    if (fuel[carModel]>carTank)
                    {
                        fuel[carModel] = carTank;
                    }
                    int fuelAfter = fuel[carModel];
                    int totalFuel = fuelAfter - fuelBefore;
                    Console.WriteLine($"{carModel} refueled with {totalFuel} liters");


                }
                else if (action=="Revert")
                {
                    int kilometers = int.Parse(cmdArg[2]);

                    mileage[carModel] -= kilometers;
                    Console.WriteLine($"{carModel} mileage decreased by {kilometers} kilometers");

                    if (mileage[carModel]<10000)
                    {
                        mileage[carModel] = 10000;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var car in mileage.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {fuel[car.Key]} lt.");
            }
        }
    }
}
