using System.Linq;

public class SearchService
{
    public static Product LinearSearch(Product[] products, string name)
    {
        foreach (Product p in products)
        {
            if (p.ProductName.Equals(name,
                StringComparison.OrdinalIgnoreCase))
            {
                return p;
            }
        }

        return null;
    }

    public static Product BinarySearch(Product[] products, string name)
    {
        Array.Sort(products,
            (a, b) => a.ProductName.CompareTo(b.ProductName));

        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int result = string.Compare(
                products[mid].ProductName,
                name,
                true);

            if (result == 0)
                return products[mid];

            if (result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}