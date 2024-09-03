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

        Console.WriteLine();
        ListProductNames(itemsInStock);

        Console.WriteLine();
        GetOverstock(itemsInStock);

        Console.WriteLine();
        PagingWithLINQ(itemsInStock);

        Console.WriteLine();
        PagingWithRanges(itemsInStock);

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

    static void ListProductNames(ProductInfo[] products)
    {
        // Get only name of products
        Console.WriteLine("***** Get only product names *****");

        var names = from p in products select p.Name;

        foreach (var name in names)
        {
            Console.WriteLine("Name: {0}", name);
        }
    }

    /// <summary>
    /// Get a subset of items based on a condition.
    /// </summary>
    /// <param name="products">IEnumerable object.</param>
    static void GetOverstock(ProductInfo[] products)
    {
        Console.WriteLine("***** Get overstock products *****");
        var overstock = from p in products where p.NumberInStock > 25 
                        select p;

        foreach(var p in overstock)
        {
            Console.WriteLine(p.ToString());
        }
    }
    static void PagingWithLINQ(ProductInfo[] products)
    {
        Console.WriteLine("***** Paging Operation *****");

        // only take the first 3 results
        IEnumerable<ProductInfo> list = (from p in products select p).Take(3);
        OutputResults("The first 3", list);

        // take while a condition is met
        IEnumerable<ProductInfo> list2 = (from p in products select p).TakeWhile(x => x.NumberInStock > 20);
        OutputResults("All while number in stock > 20", list2);

        // takes the last specified number of records
        IEnumerable<ProductInfo> list3 = (from p in products select p).TakeLast(2);
        OutputResults("last 2 records", list3);

        // skip the first three records
        IEnumerable<ProductInfo> list4 = (from p in products select p).Skip(3);
        OutputResults("Skips the first 3", list4);

        // skip while a condition, same as takewhile, when the condition returns false
        // it stops and do not continue with more record, is better to sort (orderby) before
        // calling the method
        IEnumerable<ProductInfo> list5 = (from p in products select p).SkipWhile(x => x.NumberInStock > 20);
        OutputResults("Skip while number in stock > 20", list5);

        // takes all except the last count 
        IEnumerable<ProductInfo> list6 = (from p in products select p).SkipLast(2);
        OutputResults("All but the last 2", list6);

        static void OutputResults(string message, IEnumerable<ProductInfo> products)
        {
            Console.WriteLine(message);
            foreach (ProductInfo p in products)
            {
                Console.WriteLine("\t{0}", p.ToString());
            }
        }
    }

    /// <summary>
    /// Paging with ranges support with .net > 6 and c# > 10.
    /// </summary>
    static void PagingWithRanges(ProductInfo[] products)
    {
        Console.WriteLine("***** Paging Operations (with ranges) ******");

        IEnumerable<ProductInfo> list = (from p in products select p).Take(..3);
        OutputResults("The first 3", list);

        list = (from p in products select p).Take(3..);
        OutputResults("Skipping the first 3", list);

        list = (from p in products select p).Take(^2..);
        OutputResults("The last 2", list);

        list = (from p in products select p).Take(3..2);
        OutputResults("Skip 3 and take 2", list);

        list = (from p in products select p).Take(..^2);
        OutputResults("All except the last 2", list);

        static void OutputResults(string message, IEnumerable<ProductInfo> products)
        {
            Console.WriteLine(message);

            foreach(ProductInfo p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }

   
}