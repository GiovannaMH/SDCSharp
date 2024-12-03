/*
 * You can create an array directly, but you need to determine its size first. 
 * Since arrays in C# have a fixed size, you can't dynamically add elements to them like you can with a List.
 * If you know the exact number of valid numbers beforehand or are okay with processing the file twice, 
 * you can create the array directly.
 * 
 * In this example, we process the file twice:
 */
using System;

namespace ReadingFiles5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../../../numbers1.txt"; // 

            if (System.IO.File.Exists(fileName))
            {
                string content = System.IO.File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            string[] lines = System.IO.File.ReadAllLines(fileName);

            // First pass to count valid numbers
            int validNumberCount = 0;
            foreach (string line in lines)
            {
                if (int.TryParse(line, out _))
                {
                    validNumberCount++;
                }
            }

            // Create the array with the exact size
            int[] numberArray = new int[validNumberCount];

            // Second pass to populate the array
            int index = 0;
            foreach (string line in lines)
            {
                if (int.TryParse(line, out int number))
                {
                    numberArray[index] = number; // Add valid number to the array
                    index++;
                }
                else
                {
                    Console.WriteLine($"Invalid data: {line}");
                }
            }

            // Print the array to verify
            Console.WriteLine("\nArray of numbers:");
            foreach (int num in numberArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
