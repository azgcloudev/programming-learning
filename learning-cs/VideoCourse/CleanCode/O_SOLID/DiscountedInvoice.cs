namespace O_SOLID;

public class DiscountedInvoice : Invoice
{
    // O = open/close principle 
    // this principle says that we do not modify the existing close
    // by extending the code
    public double Discount { get; set; }
}