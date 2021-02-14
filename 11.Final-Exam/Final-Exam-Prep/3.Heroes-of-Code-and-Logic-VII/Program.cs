using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            //input : Solmyr 85 120
            //          name hp mp
            var hitPoints = new Dictionary<string, int>();
            var manaPoints = new Dictionary<string, int>();


            int n = int.Parse(Console.ReadLine());

            int maxHP = 100;
            int maxMP = 200;

            for (int i = 0; i < n; i++)
            {
                string[] champs = Console.ReadLine().Split();
                string heroName = champs[0];
                int hp = int.Parse(champs[1]);
                int mp = int.Parse(champs[2]);



                hitPoints[heroName] = hp > maxHP ? maxHP : hp;//check if given hp is greater than max if greater set to max, if not set to hp
                manaPoints[heroName] = mp > maxMP ? maxMP : mp;


            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] cmdArgs = commands.Split(" - ");
                string action = cmdArgs[0];
                string heroName = cmdArgs[1];

                if (action == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];



                    if (manaPoints[heroName] >= mpNeeded)
                    {
                        manaPoints[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {manaPoints[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string atacker = cmdArgs[3];

                    hitPoints[heroName] -= damage;//if his hp drops we will check it in the if-else


                    if (hitPoints[heroName] > 0)
                    {


                        Console.WriteLine($"{heroName} was hit for {damage} HP by {atacker} and now has {hitPoints[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {atacker}!");
                        hitPoints.Remove(heroName);
                        manaPoints.Remove(heroName);
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int mpBefore = manaPoints[heroName];//take mana before we increase it 
                    manaPoints[heroName] += amount;

                    if (manaPoints[heroName]>maxMP)
                    {
                        manaPoints[heroName] = maxMP;
                    }
                    int mpAfter = manaPoints[heroName];//take mana after
                    int totalAmount = mpAfter - mpBefore;//and we divide both to find for how much is recharged
                    Console.WriteLine($"{heroName} recharged for {totalAmount} MP!");
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int hpBefore = hitPoints[heroName];

                    hitPoints[heroName] += amount;

                    if (hitPoints[heroName]>maxHP)
                    {
                        hitPoints[heroName] = maxHP;
                    }
                    int hpAfter = hitPoints[heroName];
                    int totalAmount = hpAfter - hpBefore;
                    Console.WriteLine($"{heroName} healed for {totalAmount} HP!");
                }


                commands = Console.ReadLine();
            }

            foreach (var hero in hitPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"HP: {hero.Value}");
                Console.WriteLine($"MP: {manaPoints[hero.Key]}");
            }
        }
    }
}
