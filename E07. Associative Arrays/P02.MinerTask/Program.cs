using System;
using System.Collections.Generic;

namespace P02.MinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();

            //1, 3, 5, 7 -> Odd line
            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                //if (resources.ContainsKey(resource))
                //{
                //    //The given resource already exists with some quantity
                //    resources[resource] += quantity;
                //}
                //else
                //{
                //    resources.Add(resource, quantity);
                //}

                //Add new quantity to existing one
                if (!resources.ContainsKey(resource))
                {
                    //Firstly add the new resource
                    //When adding we set default quantity to zero
                    //resources.Add(resource, 0);
                    resources[resource] = 0;
                }

                resources[resource] += quantity;

                //Get value of key
                //long goldQty = resources[resource];
            }

            foreach (var rqp in resources)
            {
                string currResource = rqp.Key;
                long resourceQty = rqp.Value;

                Console.WriteLine($"{currResource} -> {resourceQty}");
            }
        }
    }
}
