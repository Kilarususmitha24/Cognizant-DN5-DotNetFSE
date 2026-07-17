using System;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Runtime Polymorphism =====");

            Shape shape;

            shape = new Circle();
            shape.Draw();

            shape = new Rectangle();
            shape.Draw();

            Console.WriteLine();

            Console.WriteLine("===== User Choice =====");

            Console.Write("Enter Shape (1-Circle, 2-Rectangle): ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                shape = new Circle();
            }
            else
            {
                shape = new Rectangle();
            }

            shape.Draw();

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
