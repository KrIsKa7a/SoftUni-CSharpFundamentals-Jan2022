using System;
using System.Linq;

namespace P01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopsStr = Console.ReadLine();

            string cmdInfo;
            while ((cmdInfo = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = cmdInfo
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string cmdType = cmdArgs[0];

                if (cmdType == "Add Stop")
                {
                    int insertIndex = int.Parse(cmdArgs[1]);
                    string insertString = cmdArgs[2];

                    stopsStr = InsertStringAtIndex(stopsStr, insertIndex, insertString);
                    Console.WriteLine(stopsStr);
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    stopsStr = RemoveStringInRange(stopsStr, startIndex, endIndex);
                    Console.WriteLine(stopsStr);
                }
                else if (cmdType == "Switch")
                {
                    string oldString = cmdArgs[1];
                    string newString = cmdArgs[2];

                    stopsStr = ReplaceAllOccurances(stopsStr, oldString, newString);
                    Console.WriteLine(stopsStr);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stopsStr}");
        }

        static string InsertStringAtIndex(string originalStr, int insertIndex, string insertString)
        {
            if (!IsIndexValid(originalStr, insertIndex))
            {
                //If the index is invalid return original state of string (unmodified)
                return originalStr;
            }

            string modifiedStr = originalStr.Insert(insertIndex, insertString);
            return modifiedStr;
        }

        static string RemoveStringInRange(string originalStr, int startIndex, int endIndex)
        {
            if (!IsIndexValid(originalStr, startIndex))
            {
                //If startIndex is invalid, then we return original state of the string
                return originalStr;
            }

            if (!IsIndexValid(originalStr, endIndex))
            {
                //If endIndex is invalid, then we return original state of the string
                return originalStr;
            }

            string modifiedString = originalStr.Remove(startIndex, endIndex - startIndex + 1);
            return modifiedString;
        }

        static string ReplaceAllOccurances(string originalStr, string oldString, string newString)
        {
            string modifiedString = originalStr.Replace(oldString, newString);
            return modifiedString;
        }

        static bool IsIndexValid(string str, int index)
        {
            return index >= 0 && index < str.Length;
        }
    }
}
