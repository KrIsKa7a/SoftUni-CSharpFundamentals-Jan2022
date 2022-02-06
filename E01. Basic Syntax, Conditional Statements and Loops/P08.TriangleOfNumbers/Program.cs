using System;

namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                //Printing row count columns
                for (int column = 1; column <= row; column++)
                {
                    //Printing the entire row
                    Console.Write($"{row} ");
                }

                //Printing the new line/next row
                Console.WriteLine();
            }
        }
    }
}
