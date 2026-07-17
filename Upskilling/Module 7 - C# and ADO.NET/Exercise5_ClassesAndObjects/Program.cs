using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Classes and Objects =====");

            Student student1 = new Student();

            student1.Id = 101;
            student1.Name = "Sai Babu";
            student1.CGPA = 8.24;

            Console.WriteLine();

            student1.Display();

            Console.WriteLine();

            Student student2 = new Student(
                102,
                "Rahul",
                8.90
            );

            Console.WriteLine();

            student2.Display();

            Console.WriteLine();

            Console.Write("Enter Student ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter CGPA : ");
            double cgpa = Convert.ToDouble(Console.ReadLine());

            Student student3 = new Student(id, name, cgpa);

            Console.WriteLine();

            Console.WriteLine("Student Details");

            student3.Display();

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
