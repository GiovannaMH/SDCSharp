
using System;

namespace ReadingFiles4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fileName = "example.txt"; // by default the path is:
            //'C:\Users\GiovannaHumphries\source\repos\ReadingFromFiles\Ex1\bin\Debug\net7.0\example.txt'
            string fileName = "../../../../numbers.txt"; // if the file is created in the Project folder, where the .cs file is

            if (System.IO.File.Exists(fileName))
            {
                string content = System.IO.File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            string fileNum = "../../../../numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(fileNum);

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

            lines = System.IO.File.ReadAllLines(fileNum);

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
        }
    }
}
