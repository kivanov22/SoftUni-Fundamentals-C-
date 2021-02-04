using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            keyMaterials["motes"]=0;
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;

            bool hasToBreak = false;

            while (true)//when it doesn't say when it will break
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i+=2)//so we dont get index out of range, we jump with 2 iterations  cus we take 2 things from console
                {
                    int quantity = int.Parse(input[i]);//we take the number from string array
                    string material = input[i + 1].ToLower();

                    if (material=="shards" || material=="motes" || material=="fragments")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material]>=250)
                        {
                            keyMaterials[material] -= 250;

                            if (material=="shards")
                            {
                                Console.WriteLine($"Shadowmourne obtained!");
                            }
                            else if (material=="motes")
                            {
                                Console.WriteLine($"Dragonwrath obtained!");
                            }
                            else if (material=="fragments")
                            {
                                Console.WriteLine($"Valanyr obtained!");
                            }
                            hasToBreak = true;
                            break;//has to have break so we dont itterate through more inputs than needed
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }
                        junkMaterials[material] += quantity;
                    }

                }
                if (hasToBreak)
                {
                    break;
                }

            }
            Dictionary<string, int> filterKeyMaterials = keyMaterials //system Linq activate or cant order by, ToDictionary cretes it to dictionary
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in filterKeyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
