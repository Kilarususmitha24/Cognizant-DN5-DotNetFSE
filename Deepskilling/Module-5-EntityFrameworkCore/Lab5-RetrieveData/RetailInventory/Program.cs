using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

var categories = context.Categories
                        .Include(c => c.Products)
                        .ToList();

Console.WriteLine("========== Retail Inventory ==========\n");

foreach (var category in categories)
{
    Console.WriteLine($"Category : {category.Name}");

    foreach (var product in category.Products)
    {
        Console.WriteLine($"   Product : {product.Name}");
        Console.WriteLine($"   Price   : ₹{product.Price}");
        Console.WriteLine();
    }

    Console.WriteLine("--------------------------------------");
}
