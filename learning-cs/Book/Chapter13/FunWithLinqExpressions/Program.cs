using System;
using System.Linq;
using System.Collections.Generic;

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

        Console.WriteLine();
        PagingWithChunks(itemsInStock);

        Console.WriteLine();
        GetNamesAndDescriptions(itemsInStock);

        Console.WriteLine();
        GetCountFromQuery();

        Console.WriteLine();
        GetUnenumeratedCount(itemsInStock);

        Console.WriteLine();
        GetEnumeratedCountFailed(itemsInStock);

        Console.WriteLine();
        ReverseEverything(itemsInStock);

        Console.WriteLine();
        AlphabetizeProductNames(itemsInStock);

        Console.WriteLine();
        DisplayDiff();

        Console.WriteLine();
        DisplayIntersection();

        Console.WriteLine();
        DisplayUnion();

        Console.WriteLine();
        DisplayConcat();

        Console.WriteLine();
        DisplayDiffBySelector();

        Console.WriteLine();
        DisplayIntersectionBySelector();

        Console.WriteLine();
        DisplayUnionBySelector();

        Console.WriteLine();
        DisplayConcatNoDups();

        Console.WriteLine();
        DisplayConcatNoDupsBySelector();

        Console.WriteLine();
        AggregateOps();

        Console.WriteLine();
        AggregateOpsBySelector(itemsInStock);

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
        var overstock = from p in products
            where p.NumberInStock > 25
            select p;

        foreach (var p in overstock)
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

            foreach (ProductInfo p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }

    static void PagingWithChunks(ProductInfo[] products)
    {
        Console.WriteLine("***** Paging with chunks *****");

        IEnumerable<ProductInfo[]> chunks = products.Chunk(size: 2);

        var counter = 0;

        foreach (var chunk in chunks)
        {
            OutputResults($"Chunk #{++counter}", chunk);
        }

        static void OutputResults(string message, IEnumerable<ProductInfo> products)
        {
            Console.WriteLine(message);
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }

    static void GetNamesAndDescriptions(ProductInfo[] products)
    {
        Console.WriteLine("***** Names and descriptions *****");

        var nameDesc = from p in products
            select new { p.Name, p.Description };

        foreach (var item in nameDesc)
        {
            Console.WriteLine(item.ToString());
        }
    }

    // count Enumerables
    static void GetCountFromQuery()
    {
        string[] currentVideogames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

        // get count from query
        int numb = (from vg in currentVideogames
            where vg.Length > 6
            select
                vg).Count();

        // print the number of items
        Console.WriteLine("{0} items honor the LINQ query.", numb);
    }

    static void GetUnenumeratedCount(ProductInfo[] products)
    {
        Console.WriteLine("***** Get Unenumerated count *****");

        IEnumerable<ProductInfo> query = from p in products select p;
        var result = query.TryGetNonEnumeratedCount(out int count);

        if (result)
        {
            Console.WriteLine($"Total count: {count}");
        }
        else
        {
            Console.WriteLine("Try get count failed");
        }
    }

    static void GetEnumeratedCountFailed(ProductInfo[] products)
    {
        Console.WriteLine("***** Get Unenumerated count failed *****");

        var newResult = GetProduct(products).TryGetNonEnumeratedCount(out int count);

        if (newResult)
        {
            Console.WriteLine($"Total count: {count}");
        }
        else
        {
            Console.WriteLine("Try get count failed");
        }

        static IEnumerable<ProductInfo> GetProduct(ProductInfo[] products)
        {
            for (int i = 0; i < products.Count(); i++)
            {
                yield return products[i];
            }
        }
    }

    // reverse function
    static void ReverseEverything(ProductInfo[] products)
    {
        Console.WriteLine("Products in reverse:");
        var allProducts = from p in products select p;

        foreach (var p in allProducts.Reverse())
        {
            Console.WriteLine(p.ToString());
        }
    }

    // sorting using ascending and descending
    static void AlphabetizeProductNames(ProductInfo[] products)
    {
        // ascending is the default for 'orderby'
        Console.WriteLine("***** Order by ascending name: *****");

        var subset = from p in products
            orderby p.Name
            select p;
        foreach (var p in subset)
        {
            Console.WriteLine(p.ToString());
        }

        Console.WriteLine("\n***** Order by descending name: *****");

        subset = from p in products
            orderby p.Name
                descending
            select p;
        foreach (var p in subset)
        {
            Console.WriteLine(p.ToString());
        }
    }

    // Except() in Enumerable class
    static void DisplayDiff()
    {
        List<string> myCars = new List<string>()
        {
            "Yugo", "Aztec", "BMW"
        };
        List<string> yourCars = new List<string>()
        {
            "BMW", "Saab", "Aztec"
        };

        var carDiff = (from c in myCars select c)
            .Except(from c in yourCars select c);

        Console.WriteLine(">>>>> Here is what you don't have but I do: <<<<<");
        foreach (var c in carDiff)
        {
            Console.WriteLine(c); // should print Yugo
        }
    }

    // Intersect() Enumerable class method
    // return something that is in both sides
    static void DisplayIntersection()
    {
        List<string> myCars = new List<string>()
        {
            "Yugo", "Aztec", "BMW"
        };
        List<string> yourCars = new List<string>()
        {
            "BMW", "Saab", "Aztec"
        };

        Console.WriteLine(">>>>> Cars we have in common: <<<<<");

        var carIntersection = (from c in myCars select c)
            .Intersect(from c in yourCars select c);

        foreach (var c in carIntersection)
        {
            Console.WriteLine(c);
        }
    }

    // Union() from linq Enumerable
    // combine same objects from two sets
    static void DisplayUnion()
    {
        List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW" };
        List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec" };

        // get the union of this containers
        var carUnion = (from c in myCars select c)
            .Union(from c in yourCars select c);

        Console.WriteLine("***** Here is everything using Union(): *****");
        foreach (var c in carUnion)
        {
            Console.WriteLine(c);
        }
    }

    // Concat() from linq Enumerable
    // combine all elements from containers
    static void DisplayConcat()
    {
        List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW" };
        List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec" };

        var carsConcat = (from c in myCars select c)
            .Concat(from c in yourCars select c);

        Console.WriteLine(">>>>> Concat all cars <<<<<");
        foreach (var c in carsConcat)
        {
            Console.WriteLine(c);
        }
    }

    static void DisplayDiffBySelector()
    {
        var first = new (string Name, int Age)[]
        {
            ("Francis", 20), ("Lindsey", 30), ("Ashley", 40)
        };
        var second = new (string Name, int Age)[]
        {
            ("Claire", 30), ("Pat", 30), ("Drew", 30)
        };

        var result = first.ExceptBy(second.Select(x => x.Age), product => product.Age);

        Console.WriteLine(">>>>> Except for by selector: <<<<<");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    // IntersectBy() returns only one result that matches the 
    // selector value
    static void DisplayIntersectionBySelector()
    {
        var first = new (string Name, int Age)[]
        {
            ("Francis", 20), ("Lindsey", 30), ("Ashley", 40)
        };
        var second = new (string Name, int Age)[]
        {
            ("Claire", 30), ("Pat", 30), ("Drew", 30)
        };

        var result = first.IntersectBy(second.Select(x => x.Age), person => person.Age);

        Console.WriteLine(">>>>> Intersection by selector <<<<<");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// The UnionBy() return all the values from the selector. It returns the first one and do not
    /// returns duplicate values for the same value of the selector
    /// </summary>
    static void DisplayUnionBySelector()
    {
        var first = new (string Name, int Age)[]
        {
            ("Francis", 20), ("Lindsey", 30), ("Ashley", 40)
        };
        var second = new (string Name, int Age)[]
        {
            ("Claire", 30), ("Pat", 30), ("Drew", 33)
        };

        var result = first.UnionBy(second, person => person.Age);

        Console.WriteLine(">>>>> Union by selector: <<<<<");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    static void DisplayConcatNoDups()
    {
        List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW" };
        List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec" };

        var carConcat = (from c in myCars select c).Concat(from c in yourCars select c);

        Console.WriteLine(">>>> DIsplay concatenation with no duplicates using Distinct() <<<<<");
        foreach (var car in carConcat.Distinct())
        {
            Console.WriteLine(car);
        }
    }

    /// <summary>
    /// For the distinct only returns the first match of the selector matched value.
    /// </summary>
    static void DisplayConcatNoDupsBySelector()
    {
        var first = new (string Name, int Age)[]
        {
            ("Francis", 20), ("Lindsey", 30),
            ("Ashley", 40)
        };
        var second = new (string Name, int Age)[]
        {
            ("Claire", 30), ("Pat", 30), ("Drew", 33)
        };

        var result = first.Concat(second).DistinctBy(x => x.Age);

        Console.WriteLine(">>>>> Dictinct by selector <<<<<");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }


    // LINQ AGGREGATION OPERATIONS
    static void AggregateOps()
    {
        double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };

        // Max
        var maxResult = (from t in winterTemps select t).Max();
        // Min
        var minResult = (from t in winterTemps select t).Min();
        // Average
        var averageResult = (from t in winterTemps select t).Average();
        // Sum
        var sumResult = (from t in winterTemps select t).Sum();

        Console.WriteLine(">>>>> Aggregation operations <<<<<");
        Console.WriteLine($"""
                           Max temp is {maxResult}
                           Min temp is {minResult}
                           Average temp is {averageResult:N2}
                           Sum of temps is {sumResult:N2}
                           """);
    }

    static void AggregateOpsBySelector(ProductInfo[] products)
    {
        Console.WriteLine(">>>>> Aggregation by selector MaxBy() & MinBy() <<<<<");

        Console.WriteLine("Max by In Stock: {0}", products.MaxBy(x => x.NumberInStock));
        Console.WriteLine("Min by In Stock: {0}", products.MinBy(x => x.NumberInStock));
    }
}