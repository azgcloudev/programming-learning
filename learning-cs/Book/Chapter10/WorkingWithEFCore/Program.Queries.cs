using System.Linq;
using Northwind.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace WorkingWithEFCore;

// partial class Program_Queries
partial class Program
{
    private static void QueryingCategories()
    {
        using NorthwindDb db = new();

        SectionTitle("Categories and how many products they have");

        // A query to get all catagories and their related products
        IQueryable<Category>? categories = db.Categories?.Include(c => c.Products);

        if (catagories is null || !categories.Any())
        {
            Fail("No categories found.");
            return;
        }

        // execute query and enumerate results
        foreach (Category c in categories)
        {
            WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
        }
    }
}