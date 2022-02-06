using System;
using System.Linq;

namespace P03.ZigZagArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Zig zag filled arrays
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int row = 1; row <= n; row++)
            {
                int[] currentRowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = currentRowData[0];
                int secondNumber = currentRowData[1];

                if (row % 2 != 0)
                {
                    //Odd row
                    arr1[row - 1] = firstNumber;
                    arr2[row - 1] = secondNumber;
                }
                else
                {
                    //Even row
                    arr1[row - 1] = secondNumber;
                    arr2[row - 1] = firstNumber;
                }
            }

            string s1 = String.Join(" ", arr1);

            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
