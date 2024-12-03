using System;
using System.IO;
using System.Linq;

namespace ReadingFiles8
{
    class Program
    {
        static void Main()
        {
            string fileName = "../../../../numbers2.txt";

            try
            {
                // Read the entire content of the file
                string content = File.ReadAllText(fileName);

                // Split the content by common delimiters (space, comma, newline, etc.)
                int[] numbers = content
                    .Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(number =>
                    {
                        if (int.TryParse(number, out int result))
                        {
                            return result;
                        }
                        else
                        {
                            throw new FormatException($"Invalid number: '{number}'");
                        }
                    })
                    .ToArray();

                // Display the numbers
                Console.WriteLine("Numbers in the array:");
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file '{fileName}' was not found.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }

}
