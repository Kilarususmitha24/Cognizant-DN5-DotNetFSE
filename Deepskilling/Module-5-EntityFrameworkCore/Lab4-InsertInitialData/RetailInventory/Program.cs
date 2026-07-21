using RetailInventory.Data;
using RetailInventory.Models;

using var context = new AppDbContext();

context.Database.EnsureCreated();

if (!context.Categories.Any())
{
    var electronics = new Category
    {
        Name = "Electronics"
    };

    var groceries = new Category
    {
        Name = "Groceries"
    };

    context.Categories.AddRange(electronics, groceries);
    context.SaveChanges();

    context.Products.AddRange(
        new Product
        {
            Name = "Laptop",
            Price = 75000,
            CategoryId = electronics.Id
        },
        new Product
        {
            Name = "Smartphone",
            Price = 25000,
            CategoryId = electronics.Id
        },
        new Product
        {
            Name = "Rice",
            Price = 60,
            CategoryId = groceries.Id
        });

    context.SaveChanges();

    Console.WriteLine("Initial data inserted successfully.");
}
else
{
    Console.WriteLine("Data already exists.");
}
