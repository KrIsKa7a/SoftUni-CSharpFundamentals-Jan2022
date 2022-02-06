using System;
using System.Linq;

namespace P05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            //Worst case -> all integers will be top integers
            int[] topIntegers = new int[arr.Length]; // 0 0 0 0
            int topIngerersIndex = 0;  //Last index that we appended to topIntegers array

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int currentNum = arr[i];
                //By default for me it is TopInteger
                bool isTopInteger = true;

                //Nested loop that loops all indexes right to us to end
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    int nextNum = arr[j];

                    if (nextNum >= currentNum)
                    {
                        //Prove that it is not TopInteger
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers[topIngerersIndex] = currentNum;
                    topIngerersIndex++;

                    //Absoloutely same
                    //topIntegers[topIngerersIndex++] = currentNum;
                }
            }

            for (int i = 0; i < topIngerersIndex; i++)
            {
                int currentTopInteger = topIntegers[i];
                Console.Write($"{currentTopInteger} ");
            }
        }
    }
}
