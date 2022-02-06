using System;

namespace PDemo.HighOrderFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1, 2, 3, 4 };

            FilterBy(nums, IsIntegerIsOdd);
        }

        static bool IsIntegerIsOdd(int num)
        {
            return num % 2 != 0;
        }

        //Filter by what
        static int[] FilterBy(int[] nums, Func<int, bool> filter)
        {
            int[] newArray = new int[nums.Length];
            int newArrayIndex = 0;

            foreach (int num in nums)
            {
                if (filter(num))
                {
                    newArray[newArrayIndex] = num;
                    newArrayIndex++;
                }
            }

            return newArray;
        }
    }
}
