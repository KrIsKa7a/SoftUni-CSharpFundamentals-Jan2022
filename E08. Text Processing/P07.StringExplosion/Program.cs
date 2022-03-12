using System;
using System.Text;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            //Here we should store a copy of inputStr
            StringBuilder outputText = new StringBuilder();
            int bombPower = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                char currCh = inputStr[i];

                if (currCh == '>')
                {
                    //There is a bomb when '>' when hit
                    //if (i + 1 >= inputStr.Length)
                    //{
                    //    break;
                    //}
                    int currBombPower = GetIntValueOfCharacter(inputStr[i + 1]);

                    outputText.Append(currCh);
                    bombPower += currBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        //If there is detonated bomb
                        //Skips the character and decrease bomb power
                        bombPower--;
                    }
                    else
                    {
                        outputText.Append(currCh);
                    }
                }
            }

            Console.WriteLine(outputText.ToString());
        }

        static int GetIntValueOfCharacter(char ch)
        {
            return (int)ch - 48;
        }
    }
}
