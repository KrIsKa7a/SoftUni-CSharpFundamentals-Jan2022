using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<char> charList = Console.ReadLine()
            //    .ToCharArray()
            //    .ToList();

            List<string> guestList = new List<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    //The guest is going
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    //If the guest is not present in the guestlist
                    guestList.Add(name);
                }
                else if (cmdArgs.Length == 4)
                {
                    //The guest is not going
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }

                    //If the guest is present in the guestlist then we should remove it
                    guestList.Remove(name);
                }
            }

            //PrintItemsOnNewLine(guestList);
            Console.WriteLine(String.Join(Environment.NewLine, guestList));
        }

        //You must write methods here
        static void PrintItemsOnNewLine(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }

    //You must not write methods here
}
