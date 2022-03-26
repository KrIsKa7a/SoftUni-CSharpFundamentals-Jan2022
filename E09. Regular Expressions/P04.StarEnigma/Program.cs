using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D){1}\![^\@\-\!\:\>]*?\-\>(\d+)";

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);

                Match orderInfo = Regex.Match(decryptedMessage, pattern);
                if (orderInfo.Success)
                {
                    string planet = orderInfo.Groups["planet"].Value;
                    string attackType = orderInfo.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            PrintOutput(attackedPlanets, destroyedPlanets);
        }

        static void PrintOutput(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planetName in attackedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planetName}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string planetName in destroyedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planetName}");
            }
        }

        static string DecryptMessage(string encryptedMessage)
        {
            StringBuilder decryptedMessage = new StringBuilder();

            int decryptionKey = GetDecryptionKey(encryptedMessage);

            foreach (char currCh in encryptedMessage)
            {
                char decryptedCh = (char)(currCh - decryptionKey);
                decryptedMessage.Append(decryptedCh);
            }

            return decryptedMessage.ToString();
        }

        static int GetDecryptionKey(string encryptedMessage)
        {
            string decryptPattern = "[star]{1}";
            MatchCollection matches = 
                Regex.Matches(encryptedMessage, decryptPattern, RegexOptions.IgnoreCase);

            return matches.Count;
        }
    }
}
