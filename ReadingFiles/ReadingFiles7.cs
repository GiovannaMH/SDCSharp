/*
 * You can use a List<int> to collect the valid numbers and then convert it into an array.
 */

using System;
using System.Collections.Generic;

namespace ReadingFiles7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adjust the file path to point to the project folder
            string fileName = "../../../../numbers1.txt";

            if (!System.IO.File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
            }
            else
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);

                // First foreach loop to print numbers and invalid data
                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        Console.WriteLine($"Number: {number}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid data: {line}");
                    }
                }

                // Create a list to collect valid numbers
                List<int> numberList = new List<int>();

                // Second foreach loop to process numbers and store them in a list
                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        numberList.Add(number); // Add valid numbers to the list
                    }
                    else
                    {
                        Console.WriteLine($"Invalid data: {line}");
                    }
                }

                // Convert the list to an array
                int[] numberArray = numberList.ToArray();

                // Print the array to verify
                Console.WriteLine("\nArray of numbers:");
                foreach (int num in numberArray)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
