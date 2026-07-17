using System;
using System.Data;

namespace DataTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== DataTable Example =====\n");

            DataTable students = new DataTable("Students");

            students.Columns.Add("Id", typeof(int));
            students.Columns.Add("Name", typeof(string));
            students.Columns.Add("Department", typeof(string));
            students.Columns.Add("Marks", typeof(int));

            students.Rows.Add(101, "Sai Babu", "CSE", 91);
            students.Rows.Add(102, "Rahul", "ECE", 85);
            students.Rows.Add(103, "Anjali", "IT", 95);

            Console.WriteLine("===== Initial Records =====\n");

            DisplayTable(students);

            students.Rows[1]["Marks"] = 90;

            Console.WriteLine("\n===== After Updating Rahul's Marks =====\n");

            DisplayTable(students);

            students.Rows[0].Delete();

            students.AcceptChanges();

            Console.WriteLine("\n===== After Deleting First Record =====\n");

            DisplayTable(students);

            Console.WriteLine("\n===== Add New Student =====");

            Console.Write("Enter ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Department : ");
            string department = Console.ReadLine();

            Console.Write("Enter Marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());

            students.Rows.Add(id, name, department, marks);

            Console.WriteLine("\n===== Final DataTable =====\n");

            DisplayTable(students);

            Console.WriteLine("\nTotal Records : " + students.Rows.Count);

            Console.WriteLine("\nProgram Completed Successfully.");

            Console.ReadKey();
        }

        static void DisplayTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(
                    $"{row["Id"]}\t{row["Name"]}\t{row["Department"]}\t{row["Marks"]}"
                );
            }
        }
    }
}
