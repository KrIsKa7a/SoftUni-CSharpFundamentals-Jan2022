using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int index = int.Parse(Console.ReadLine());
            int overallSum = 0;

            while (pokemons.Count > 0)
            {
                CatchPokemons(pokemons, index, out int sum);
                overallSum += sum;

                // If there are no elements, break
                if (pokemons.Count == 0)
                {
                    break;
                }

                index = int.Parse((Console.ReadLine()));
            }

            Console.WriteLine(overallSum);
        }

        static List<int> CatchPokemons(List<int> pokemons, int index, out int sum)
        {
            // If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place. Add the removed element to the sum
            if (index < 0)
            {
                int removedItem = pokemons[0];
                pokemons.RemoveAt(0);
                pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                sum = removedItem;
                // Increase or decrease the elements of the collection depending on the value of the removed element
                IncreaseOrDecreaseElements(pokemons, removedItem);
            }
            // If the given index is greater than the last index of the sequence, remove the last element from the sequence, and copy the first element to its place. Add the removed element to the sum
            else if (index >= pokemons.Count)
            {
                int removedItem = pokemons[pokemons.Count - 1];
                pokemons.RemoveAt(pokemons.Count - 1);
                pokemons.Add(pokemons[0]);
                sum = removedItem;
                // Increase or decrease the elements of the collection depending on the value of the removed element
                IncreaseOrDecreaseElements(pokemons, removedItem);
            }
            // If the index is in the range of the collection remove the element at that index. Add the removed element to the sum
            else
            {
                int removedItem = pokemons[index];
                pokemons.RemoveAt(index);
                sum = removedItem;
                // Increase or decrease the elements of the collection depending on the value of the removed element
                IncreaseOrDecreaseElements(pokemons, removedItem);
            }
                        
            return pokemons;
        }

        static List<int> IncreaseOrDecreaseElements(List<int> pokemons, int removedItem)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                // If the element is less or equeal to the removed element, increase the element by the removed element
                if(pokemons[i] <= removedItem)
                {
                    pokemons[i] += removedItem;
                }
                // If the element is larger than the removed element, decrease the element by the removed element
                else if (pokemons[i] > removedItem)
                {
                    pokemons[i] -= removedItem;
                }
            }

            return pokemons;
        }
    }
}
