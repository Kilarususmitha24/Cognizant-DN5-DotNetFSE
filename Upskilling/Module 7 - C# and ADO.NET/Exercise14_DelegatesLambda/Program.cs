using System;

namespace DelegatesLambdaDemo
{
    // Delegate Declaration
    delegate int Calculate(int a, int b);

    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Delegates Example =====");

            Calculate calc = Add;

            Console.WriteLine("Addition = " + calc(10, 20));

            calc = Multiply;

            Console.WriteLine("Multiplication = " + calc(10, 20));

            Console.WriteLine();

            Console.WriteLine("===== Lambda Expression =====");

            Calculate subtract = (a, b) => a - b;

            Console.WriteLine("Subtraction = " + subtract(30, 10));

            Calculate divide = (a, b) => a / b;

            Console.WriteLine("Division = " + divide(20, 5));

            Console.WriteLine();

            Console.WriteLine("===== Func Delegate =====");

            Func<int, int, int> maximum = (x, y) =>
            {
                return x > y ? x : y;
            };

            Console.WriteLine("Maximum = " + maximum(50, 70));

            Console.WriteLine();

            Console.WriteLine("===== Action Delegate =====");

            Action<string> greet = name =>
            {
                Console.WriteLine("Welcome " + name);
            };

            greet("Sai Babu");

            Console.WriteLine();

            Console.WriteLine("===== User Input =====");

            Console.Write("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Addition = " + Add(num1, num2));

            Console.WriteLine("Multiplication = " + Multiply(num1, num2));

            Console.WriteLine("Subtraction = " + subtract(num1, num2));

            Console.WriteLine("Maximum = " + maximum(num1, num2));

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
