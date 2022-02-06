
using System;
using System.Numerics;

namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "SoftUni";
            Console.WriteLine(s[^1]);

            Math.Pow(2, 10); //-> 2^10 = 1024
            BigInteger.Pow(2, 10000); //-> 2^1000 = 1.07*10^30

            int parsedNum;
            bool isInteger = int.TryParse(Console.ReadLine(), out parsedNum);

            if (isInteger)
            {
                Console.WriteLine($"The text was the integer: {parsedNum}");
            }
            else
            {
                Console.WriteLine("The text was not integer!");
            }


            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.Write($"{ch} ");
            }

            Console.WriteLine();
            Console.WriteLine("-----------------");

            int a = 1;
            int b = 1;
            Console.WriteLine(5 + a++); //Post Incrementation -> 6
            Console.WriteLine(5 + ++b); //Pre Incrementation -> 7
        }
    }
}
