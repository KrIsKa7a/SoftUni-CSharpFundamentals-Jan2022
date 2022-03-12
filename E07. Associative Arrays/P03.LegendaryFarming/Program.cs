using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo for passing parameter by reference vs by value
            //int a = 7;
            //PassByValue(ref a);
            //Console.WriteLine($"Main: a = {a}");

            //In this dict we will store only the key materials: shards, fragments, motes
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 },
            };
            //In this dict we will store all other materials (aka junk)
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string itemObtained = string.Empty;

            //I do not know how many lines I should read
            while (String.IsNullOrEmpty(itemObtained))
            {
                //The programm must be Case-Insensitive
                string materialsLine = Console.ReadLine().ToLower();
                string[] materialsArr = materialsLine
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                ProcessInputLine(keyMaterials, junk, materialsArr, ref itemObtained);
            }

            PrintOutput(keyMaterials, junk, itemObtained);
        }

        static void ProcessInputLine(Dictionary<string, int> keyMaterials, Dictionary<string, int> junk, 
            string[] materialsArr, ref string itemObtained)
        {
            const int minCraftMaterialQty = 250;
            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne" },
                { "fragments", "Valanyr" },
                { "motes", "Dragonwrath" }
            };

            for (int i = 0; i < materialsArr.Length; i += 2)
            {
                int currMaterialQty = int.Parse(materialsArr[i]);
                string currMaterial = materialsArr[i + 1];

                if (keyMaterials.ContainsKey(currMaterial))
                {
                    //The currMaterial is a Key Material
                    keyMaterials[currMaterial] += currMaterialQty;

                    if (keyMaterials[currMaterial] >= minCraftMaterialQty)
                    {
                        itemObtained = craftingTable[currMaterial];
                        keyMaterials[currMaterial] -= minCraftMaterialQty;

                        break;
                    }
                }
                else
                {
                    //The currMaterial is a junk
                    if (!junk.ContainsKey(currMaterial))
                    {
                        junk[currMaterial] = 0;
                    }

                    junk[currMaterial] += currMaterialQty;
                }
            }
        }

        static void PrintOutput(Dictionary<string, int> keyMaterialsLeft, Dictionary<string, int> junk,
            string itemObtained)
        {
            Console.WriteLine($"{itemObtained} obtained!");

            foreach (var kvp in keyMaterialsLeft)
            {
                string keyMaterial = kvp.Key;
                int qtyLeft = kvp.Value;

                Console.WriteLine($"{keyMaterial}: {qtyLeft}");
            }

            foreach (var kvp in junk)
            {
                string junkMaterial = kvp.Key;
                int junkQty = kvp.Value;

                Console.WriteLine($"{junkMaterial}: {junkQty}");
            }
        }

        static void PassByValue(ref int a)
        {
            a = 5;

            Console.WriteLine($"Method: a = {a}");
        }
    }
}
