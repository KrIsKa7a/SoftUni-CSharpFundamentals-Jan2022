using System;
using System.Linq;

namespace P04.ArrayRotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            int rotationsCountReduced = rotationsCount % arr.Length;

            for (int rot = 1; rot <= rotationsCountReduced; rot++)
            {
                int firstEl = arr[0]; //Not to lose first element
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    //arr[0] = arr[1]
                    //arr[3] = arr[4]
                    // 0 1 2 3 4 5
                    // 2 5 7 8 9 0
                    // 5 7 8 9 0 2
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstEl;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
