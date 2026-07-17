using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Interface Example =====");

            Report report1 = new Report(
                "Community Event Report",
                "Susmitha"
            );

            report1.Print();

            Console.WriteLine();

            Console.WriteLine("Enter Report Details");

            Console.Write("Title : ");
            string title = Console.ReadLine();

            Console.Write("Author : ");
            string author = Console.ReadLine();

            Console.WriteLine();

            Report report2 = new Report(title, author);

            report2.Print();

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
