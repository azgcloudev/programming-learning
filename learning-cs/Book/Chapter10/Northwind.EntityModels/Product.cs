using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.EntityModels;

public class Product
{
    public int ProductId { get; set; }

    [Required] [StringLength(40)] public string ProductName { get; set; } = null!;

    [Column("UnitPrice", TypeName = "money")]
    public decimal? Cost { get; set; }

    [Column("UnitInStock")] public short? Stock { get; set; }

    // relationship to the Categories table
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
}