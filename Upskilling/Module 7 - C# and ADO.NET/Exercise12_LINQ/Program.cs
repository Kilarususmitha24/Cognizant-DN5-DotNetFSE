using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 101, Name = "Sai", Marks = 91 },
                new Student { Id = 102, Name = "Rahul", Marks = 78 },
                new Student { Id = 103, Name = "Anjali", Marks = 88 },
                new Student { Id = 104, Name = "Kiran", Marks = 65 },
                new Student { Id = 105, Name = "Meena", Marks = 95 }
            };

            Console.WriteLine("===== All Students =====");

            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Id}  {s.Name}  {s.Marks}");
            }

            Console.WriteLine();

            Console.WriteLine("===== Students with Marks >= 80 =====");

            var result = students.Where(s => s.Marks >= 80);

            foreach (Student s in result)
            {
                Console.WriteLine($"{s.Name} - {s.Marks}");
            }

            Console.WriteLine();

            Console.WriteLine("===== Order By Marks =====");

            var ordered = students.OrderBy(s => s.Marks);

            foreach (Student s in ordered)
            {
                Console.WriteLine($"{s.Name} - {s.Marks}");
            }

            Console.WriteLine();

            Console.WriteLine("===== Student Names =====");

            var names = students.Select(s => s.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("===== First Student =====");

            Student first = students.FirstOrDefault();

            Console.WriteLine(first.Name);

            Console.WriteLine();

            Console.WriteLine("===== Statistics =====");

            Console.WriteLine("Total Students : " + students.Count());

            Console.WriteLine("Highest Marks : " + students.Max(s => s.Marks));

            Console.WriteLine("Lowest Marks : " + students.Min(s => s.Marks));

            Console.WriteLine("Average Marks : " + students.Average(s => s.Marks));

            Console.WriteLine("Total Marks : " + students.Sum(s => s.Marks));

            Console.WriteLine();

            Console.WriteLine("===== User Search =====");

            Console.Write("Enter Student Name : ");

            string search = Console.ReadLine();

            var student = students.FirstOrDefault(s =>
                s.Name.Equals(search, StringComparison.OrdinalIgnoreCase));

            if (student != null)
            {
                Console.WriteLine($"Found : {student.Name} ({student.Marks})");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
