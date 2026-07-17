using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Inheritance Example =====");

            Dog dog = new Dog();

            dog.Name = "Tommy";
            dog.Breed = "Golden Retriever";

            Console.WriteLine();

            dog.Display();

            Console.WriteLine();

            dog.Eat();

            dog.Sleep();

            dog.Bark();

            Console.WriteLine();

            Console.WriteLine("Enter Dog Details");

            Console.Write("Dog Name : ");
            dog.Name = Console.ReadLine();

            Console.Write("Breed : ");
            dog.Breed = Console.ReadLine();

            Console.WriteLine();

            dog.Display();

            Console.WriteLine();

            dog.Eat();

            dog.Sleep();

            dog.Bark();

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
