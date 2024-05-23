namespace O_SOLID;

public class DiscountedBillingService : BillingService
{
    public override double CalculateTotal(Invoice invoice)
    {
        if (invoice is DiscountedInvoice discountedInvoice)
        {
            return discountedInvoice.Amount - discountedInvoice.Discount;
        }

        return base.CalculateTotal(invoice);
    }
}