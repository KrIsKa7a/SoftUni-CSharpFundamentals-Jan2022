using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string number = Console.ReadLine();

            //Action
            //145 = 1! + 4! + 5!
            long factorialSum = 0;
            for (int i = 0; i <= number.Length - 1; i++)
            {
                //Digit as an ASCII character
                char currCh = number[i];
                int currDigit = (int)currCh - 48;

                long currDigitFactorial = 1;
                for (int r = currDigit; r > 1; r--)
                {
                    currDigitFactorial *= r;
                    //currDigitFactorial = currDigitFactorial * r;
                }

                factorialSum += currDigitFactorial;
            }

            //Output
            if (factorialSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
