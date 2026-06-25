class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product(1,"Laptop","Electronics"),
            new Product(2,"Phone","Electronics"),
            new Product(3,"Shoes","Fashion")
        };

        Product result =
            SearchService.LinearSearch(products,"Phone");

        Console.WriteLine(result.ProductName);
    }
}