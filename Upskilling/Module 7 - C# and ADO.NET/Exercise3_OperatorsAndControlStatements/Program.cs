using System;

namespace OperatorsAndControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;

            Console.WriteLine("===== Arithmetic Operators =====");
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));

            Console.WriteLine();

            Console.WriteLine("===== Relational Operators =====");
            Console.WriteLine("a > b : " + (a > b));
            Console.WriteLine("a < b : " + (a < b));
            Console.WriteLine("a == b : " + (a == b));
            Console.WriteLine("a != b : " + (a != b));

            Console.WriteLine();

            Console.WriteLine("===== Logical Operators =====");
            bool x = true;
            bool y = false;

            Console.WriteLine("x && y : " + (x && y));
            Console.WriteLine("x || y : " + (x || y));
            Console.WriteLine("!x : " + (!x));

            Console.WriteLine();

            Console.Write("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("===== If-Else =====");

            if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: Fail");
            }

            Console.WriteLine();

            Console.WriteLine("===== Switch Statement =====");

            Console.Write("Enter Choice (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You Selected Java");
                    break;

                case 2:
                    Console.WriteLine("You Selected C#");
                    break;

                case 3:
                    Console.WriteLine("You Selected Python");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("===== For Loop =====");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("===== While Loop =====");

            int j = 1;

            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine();

            Console.WriteLine("===== Do While Loop =====");

            int k = 1;

            do
            {
                Console.WriteLine(k);
                k++;
            }
            while (k <= 5);

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
