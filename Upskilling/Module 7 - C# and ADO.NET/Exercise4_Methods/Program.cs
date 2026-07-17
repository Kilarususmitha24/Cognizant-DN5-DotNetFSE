using System;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Methods in C# =====");

            DisplayMessage();

            Console.WriteLine();

            AddNumbers(10, 20);

            Console.WriteLine();

            int square = FindSquare(6);

            Console.WriteLine("Square = " + square);

            Console.WriteLine();

            // Method Overloading
            Console.WriteLine("===== Method Overloading =====");

            Console.WriteLine("Sum = " + Add(10, 15));

            Console.WriteLine("Sum = " + Add(10.5, 15.2));

            Console.WriteLine();

            Console.Write("Enter Your Name: ");

            string name = Console.ReadLine();

            Welcome(name);

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to Cognizant DN 5.0");
        }

        static void AddNumbers(int a, int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }

        static int FindSquare(int number)
        {
            return number * number;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static void Welcome(string user)
        {
            Console.WriteLine("Welcome " + user);
        }
    }
}
