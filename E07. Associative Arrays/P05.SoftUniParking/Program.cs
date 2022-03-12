using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Key:User -> Value:License Plater Num
            Dictionary<string, string> parkingRegister = 
                new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];
                string username = cmdArgs[1];

                if (cmdType == "register")
                {
                    string licensePlateNumber = cmdArgs[2];

                    RegisterUser(parkingRegister, username, licensePlateNumber);
                }
                else if (cmdType == "unregister")
                {
                    UnRegisterUser(parkingRegister, username);
                }
            }

            foreach (var kvp in parkingRegister)
            {
                string username = kvp.Key;
                string licensePlateNumber = kvp.Value;

                Console.WriteLine($"{username} => {licensePlateNumber}");
            }
        }

        static void RegisterUser(Dictionary<string, string> parkingRegister,
            string username, string licensePlateNumber)
        {
            if (parkingRegister.ContainsKey(username))
            {
                //Already registered
                string licenseNumberRegistered = parkingRegister[username];

                Console.WriteLine($"ERROR: already registered with plate number {licenseNumberRegistered}");
            }
            else
            {
                //Register the user with corresponding license plate number
                parkingRegister[username] = licensePlateNumber;

                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
        }

        static void UnRegisterUser(Dictionary<string, string> parkingRegister,
            string username)
        {
            if (!parkingRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                parkingRegister.Remove(username);

                Console.WriteLine($"{username} unregistered successfully");
            }
        }
    }
}
