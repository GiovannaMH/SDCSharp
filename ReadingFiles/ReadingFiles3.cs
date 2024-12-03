
//Step 3: Read a File Using a StreamReader
//StreamReader provides more control over file reading and is suitable for large files.

using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace ReadingFiles3
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
                // Open the file using StreamReader
                using (StreamReader reader = new StreamReader(fileName))
                {
                    Console.WriteLine("Reading File Using StreamReader:");

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

//StreamReader reads files line by line, which is memory-efficient for large files.
//Use using to ensure the file is closed after reading.
