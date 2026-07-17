using System;
using System.IO;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "sample.txt";

            Console.WriteLine("===== File Handling in C# =====");

            // Write to File
            File.WriteAllText(filePath,
                "Welcome to Cognizant DN 5.0\n" +
                "This file is created using C#.\n" +
                "Learning File Handling.");

            Console.WriteLine("File Created Successfully.");

            Console.WriteLine();

            // Check File Exists
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists.");
            }

            Console.WriteLine();

            // Read File
            Console.WriteLine("===== File Content =====");

            string content = File.ReadAllText(filePath);

            Console.WriteLine(content);

            Console.WriteLine();

            // Append Data
            File.AppendAllText(filePath,
                "\nThis line is appended.");

            Console.WriteLine("Data Appended Successfully.");

            Console.WriteLine();

            Console.WriteLine("===== Updated File =====");

            Console.WriteLine(File.ReadAllText(filePath));

            Console.WriteLine();

            Console.WriteLine("===== StreamWriter =====");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Using StreamWriter");
                writer.WriteLine("Line 1");
                writer.WriteLine("Line 2");
                writer.WriteLine("Line 3");
            }

            Console.WriteLine("Data Written Using StreamWriter.");

            Console.WriteLine();

            Console.WriteLine("===== StreamReader =====");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
