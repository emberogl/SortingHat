using System;

namespace SortingHat
{
    internal class SortingHat
    {
        // Enum representing Hogwarts houses
        public enum Houses
        {
            Gryffindor,
            Hufflepuff,
            Ravenclaw,
            Slytherin
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                // Casting random integer to enum type to retrieve value, argument 2 creates array of enum values and gets length
                Console.WriteLine($"You belong to {(Houses)random.Next(0, Enum.GetValues(typeof(Houses)).Length)}!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}