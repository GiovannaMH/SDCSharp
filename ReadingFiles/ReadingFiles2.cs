
//Step 2: Read a File Line by Line
//For larger files, it's better to read line by line using File.ReadLines or File.ReadAllLines.

using System;
using System.Runtime.Intrinsics.X86;

namespace ReadingFiles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fileName = "example.txt"; // by default the path is:
            //'C:\Users\GiovannaHumphries\source\repos\ReadingFromFiles\Ex1\bin\Debug\net7.0\example.txt'
            string fileName = "../../../../example.txt"; // if the file is created in the Project folder, where the .cs file is

            try
            {
                // Read all lines into an array
                string[] lines = System.IO.File.ReadAllLines(fileName);

                Console.WriteLine("File Content Line by Line:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

//File.ReadAllLines reads all lines into a string array.
//Use a foreach loop to process each line.
