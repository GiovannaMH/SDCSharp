using System;
using System.Collections.Generic; // Required namespace for List

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a list of strings
            List<string> fruits = new List<string>();

            // Step 2: Add items to the list
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            Console.WriteLine("Fruits after adding:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Step 3: Remove an item from the list
            fruits.Remove("Banana");
            Console.WriteLine("\nFruits after removing 'Banana':");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Step 4: Access an item by its index
            Console.WriteLine($"\nThe first fruit in the list is: {fruits[0]}");

            // Step 5: Insert an item at a specific index
            fruits.Insert(1, "Blueberry");
            Console.WriteLine("\nFruits after inserting 'Blueberry' at index 1:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Step 6: Check the total number of items in the list
            Console.WriteLine($"\nThe list contains {fruits.Count} fruits.");
            
        }
    }
}
