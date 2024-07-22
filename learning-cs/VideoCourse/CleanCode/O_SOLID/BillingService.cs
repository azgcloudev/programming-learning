namespace O_SOLID;

public class BillingService
{
    public virtual double CalculateTotal(Invoice invoice)
    {
        return invoice.Amount;
    }
}