using System;

namespace P04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char currCh = char.Parse(Console.ReadLine());
                int currChCode = (int)currCh;

                sum += currChCode;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
