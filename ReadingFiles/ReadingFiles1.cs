//Step 1: Read the Entire File as Text
//This is suitable for small files.
//Use a try-catch block to handle errors like missing files.
using System;
namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fileName = "example.txt"; // by default the path is:
            //'C:\Users\GiovannaHumphries\source\repos\ReadingFromFiles\Ex1\bin\Debug\net7.0\example.txt'
            //string fileName = "../../../example.txt"; // if the file is created in the Project folder, where the .cs file is
            string fileName = "../../../../example.txt"; // if the file is created in the Solution, to be accessible to all projects inside

            try
            {
                // Read the entire content of the file as a single string
                string content = System.IO.File.ReadAllText(fileName);
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                // Handle errors such as file not found
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
