using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Match -> signle match
            //Matches -> collection of all matches
            //Dictionary<string, string> alphabets = new Dictionary<string, string>();
            //alphabets.Add("en", "[A-Za-z]+");
            //alphabets.Add("bg", "[А-Яа-я]+");
            List<string> furnitureBought = new List<string>();
            decimal totalMoneySpend = 0m;

            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";
            //Dynamic pattern for different languages
            //string pattern = @"[>]{2}(?<name>{0}+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";
            //pattern = String.Format(pattern, alphabets["bg"]);

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, pattern);

                if (furnitureInfo.Success)
                {
                    string furnitireName = furnitureInfo.Groups["name"].Value;
                    decimal price = 
                        decimal.Parse(furnitureInfo.Groups["price"].Value);
                    int quantity = 
                        int.Parse(furnitureInfo.Groups["quantity"].Value);

                    furnitureBought.Add(furnitireName);
                    totalMoneySpend += price * quantity;
                }
            }

            PrintOutput(furnitureBought, totalMoneySpend);
        }

        static void PrintOutput(List<string> furnitures, decimal moneySpend)
        {
            Console.WriteLine("Bought furniture:");

            foreach (string furnitureName in furnitures)
            {
                Console.WriteLine(furnitureName);
            }

            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
