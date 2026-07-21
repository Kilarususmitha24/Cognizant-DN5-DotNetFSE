Console.WriteLine("Hello, World!");
using System;
using RetailInventory.Data;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            Console.WriteLine("Database Context Created Successfully");
        }
    }
}
