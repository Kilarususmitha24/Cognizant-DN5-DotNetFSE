using System;
using RetailInventory.Data;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("EF Core Migration Demo");
        }
    }
}
