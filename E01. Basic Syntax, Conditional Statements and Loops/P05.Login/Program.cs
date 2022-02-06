using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string username = Console.ReadLine();

            //Actions + Output
            //Reverse the username - Basic Solution
            string password = string.Empty; //""
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            for (int count = 1; count <= 4; count++)
            {
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        continue; //Can be omitted
                    }
                }
            }
        }
    }
}
