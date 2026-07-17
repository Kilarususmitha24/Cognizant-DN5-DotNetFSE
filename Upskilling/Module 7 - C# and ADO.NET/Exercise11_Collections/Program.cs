using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== List Collection =====");

            List<string> students = new List<string>();

            students.Add("Sai Babu");
            students.Add("Rahul");
            students.Add("Anjali");
            students.Add("Kiran");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("===== Dictionary Collection =====");

            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "Sai");
            employees.Add(102, "Rahul");
            employees.Add(103, "Anjali");

            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine();

            Console.WriteLine("===== HashSet Collection =====");

            HashSet<string> cities = new HashSet<string>();

            cities.Add("Hyderabad");
            cities.Add("Guntur");
            cities.Add("Vijayawada");
            cities.Add("Hyderabad");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();

            Console.WriteLine("===== Queue Collection =====");

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Student 1");
            queue.Enqueue("Student 2");
            queue.Enqueue("Student 3");

            Console.WriteLine("Removed : " + queue.Dequeue());

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("===== Stack Collection =====");

            Stack<string> stack = new Stack<string>();

            stack.Push("Book 1");
            stack.Push("Book 2");
            stack.Push("Book 3");

            Console.WriteLine("Removed : " + stack.Pop());

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("===== User Input List =====");

            List<string> names = new List<string>();

            Console.Write("How many names? : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter Name " + i + " : ");
                names.Add(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Names Entered");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
