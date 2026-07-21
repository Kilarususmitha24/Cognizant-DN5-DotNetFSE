Console.WriteLine("Hello, World!");
using System;
using RetailInventory.Models;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 75000,
                Stock = 15
            };

            Console.WriteLine("Retail Inventory System");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Product Id : {product.Id}");
            Console.WriteLine($"Product Name : {product.Name}");
            Console.WriteLine($"Price : ₹{product.Price}");
            Console.WriteLine($"Stock : {product.Stock}");
        }
    }
}
