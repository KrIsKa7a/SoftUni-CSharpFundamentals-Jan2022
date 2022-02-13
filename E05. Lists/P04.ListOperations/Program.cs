using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    int appendNumber = int.Parse(cmdArgs[1]);

                    numbers.Add(appendNumber);
                }
                else if (cmdType == "Insert")
                {
                    int insertNumber = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (!IsIndexValid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, insertNumber);
                }
                else if (cmdType == "Remove")
                {
                    int removeIndex = int.Parse(cmdArgs[1]);

                    if (!IsIndexValid(numbers, removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(removeIndex);
                }
                else if (cmdType == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);
                    
                    if (direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static bool IsIndexValid(List<int> numbers, int index)
        {
            return index >= 0 && index < numbers.Count;
        }

        static void ShiftLeft(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            //Counter for shifts
            //Shift count times
            for (int cnt = 1; cnt <= realPerformedCount; cnt++)
            {
                //Take first element in order not to lose its value
                //int firstElement = numbers[0];
                int firstElement = numbers.First();
                //We remove the first element
                //numbers.RemoveAt(0);
                numbers.Remove(firstElement);
                //Then we append first element at last
                numbers.Add(firstElement);
            }
        }

        static void ShiftRight(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int cnt = 1; cnt <= realPerformedCount; cnt++)
            {
                //Take the last element in order not to lose its value
                //int lastElement = numbers[numbers.Count - 1];
                int lastElement = numbers.Last();
                //We remove the last element
                //numbers.Remove(lastElement); In some cases this might not work
                numbers.RemoveAt(numbers.Count - 1);
                //We insert it in the start of the list
                numbers.Insert(0, lastElement);
            }
        }
    }
}
