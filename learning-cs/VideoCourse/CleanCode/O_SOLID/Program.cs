namespace O_SOLID;

class Program
{
    static void Main(string[] args)
    {
        Invoice invoice = new Invoice() { Amount = 100 };
        BillingService billingService = new BillingService();
        double total = billingService.CalculateTotal(invoice);
        Console.WriteLine($"Total: {total}");
        
        // using the extended class
        DiscountedInvoice discountedInvoice = new DiscountedInvoice() { Amount = 100, Discount = 25 };
        DiscountedBillingService discountedBillingService = new DiscountedBillingService();
        Console.WriteLine($"Total with {discountedInvoice.Discount} discount: {discountedBillingService.CalculateTotal(discountedInvoice)}");
    }
}