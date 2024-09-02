namespace FunWithLinqExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Query Expressions *****\n");

        ProductInfo[] itemsInStock = new[]
        {
            new ProductInfo
            {
                Name = "Mac's Coffee", Description = "Coffee with TEETH",
                NumberInStock = 24
            },
            new ProductInfo
            {
                Name = "Milk Maid Milk", Description = "Milk cow's love",
                NumberInStock = 100
            },
            new ProductInfo
            {
                Name = "Pure Silk Tofu", Description = "Bland as Possible",
                NumberInStock = 120
            },
            new ProductInfo
            {
                Name = "Crunchy Pops", Description = "Cheezy, peppery goodness",
                NumberInStock = 2
            },
            new ProductInfo
            {
                Name = "RipOff Water", Description = "From the tap to your wallet",
                NumberInStock = 100
            },
            new ProductInfo
            {
                Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!",
                NumberInStock = 73
            }
        };
        
        SelectEverything(itemsInStock);

        Console.ReadLine();
    }

    /// <summary>
    /// Selects all items in array using LINQ.
    /// </summary>
    /// <param name="products">Array of ProductInfo</param>
    static void SelectEverything(ProductInfo[] products)
    {
        Console.WriteLine("***** Select all products *****");
        
        var allProducts = from p in products select p;

        foreach (var p in allProducts)
        {
            Console.WriteLine(p.ToString());
        }
    }
}