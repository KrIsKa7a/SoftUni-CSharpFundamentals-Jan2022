using System;

namespace BasicSyntaxExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num = int.Parse(Console.ReadLine());

            //Actions
            //By default if number is not divisible by any number we take divider -1
            int divider = -1; //0 //1

            if (num % 10 == 0)
            {
                divider = 10;
            }
            else if (num % 7 == 0)
            {
                divider = 7;
            }
            else if (num % 6 == 0)
            {
                divider = 6;
            }
            else if (num % 3 == 0)
            {
                divider = 3;
            }
            else if (num % 2 == 0)
            {
                divider = 2;
            }

            //Output
            if (divider == -1)
            {
                //Not if statement was executed
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divider}");
            }
        }
    }
}
