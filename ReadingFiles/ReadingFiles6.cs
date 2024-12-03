/*
 * You can create an array directly, but you need to determine its size first. 
 * Since arrays in C# have a fixed size, you can't dynamically add elements to them like you can with a List.
 * If you know the exact number of valid numbers beforehand or are okay with processing the file twice, 
 * you can create the array directly.
 * 
 * In this example, the first number read is how many numbers we read. Then we declare an array with that many elements.
 * Then we read the rest of the numbers and add them to the array:
 */

using System;

namespace ReadingFiles6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File path (adjust as needed)
            string fileName = "../../../../numbers1.txt";

            if (System.IO.File.Exists(fileName))
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);

                // Ensure the file has at least one line
                if (lines.Length == 0)
                {
                    Console.WriteLine("File is empty.");
                    return;
                }

                // Read the first line to get the number of elements
                if (int.TryParse(lines[0], out int arraySize) && arraySize > 0)
                {
                    // Create an array with the specified size
                    int[] numberArray = new int[arraySize];

                    // Read the next `arraySize` numbers into the array
                    int index = 0;
                    for (int i = 1; i < lines.Length && index < arraySize; i++)
                    {
                        if (int.TryParse(lines[i], out int number))
                        {
                            numberArray[index] = number;
                            index++;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid data: {lines[i]}");
                        }
                    }

                    // Check if we read the expected number of elements
                    if (index < arraySize)
                    {
                        Console.WriteLine($"Warning: Expected {arraySize} numbers, but only {index} were valid.");
                    }

                    // Print the array
                    Console.WriteLine("\nArray of numbers:");
                    foreach (int num in numberArray)
                    {
                        Console.WriteLine(num);
                    }
                }
                else
                {
                    Console.WriteLine("The first line of the file must be a positive integer.");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
