using System;

namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Encapsulation Example =====");

            Employee emp = new Employee();

            emp.EmployeeId = 101;
            emp.EmployeeName = "Sai Babu";
            emp.Salary = 50000;

            Console.WriteLine();

            emp.Display();

            Console.WriteLine();

            Console.WriteLine("Enter Employee Details");

            Console.Write("Employee ID : ");
            emp.EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Employee Name : ");
            emp.EmployeeName = Console.ReadLine();

            Console.Write("Salary : ");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Updated Employee Details");

            emp.Display();

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
