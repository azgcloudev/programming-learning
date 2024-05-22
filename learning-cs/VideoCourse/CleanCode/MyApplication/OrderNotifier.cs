namespace MyApplication;

public class OrderNotifier
{
    public void NotifyCustomer(Order order)
    {
        // Send notification to the customer
        Console.WriteLine($"Customer notified for order {order.Id}.");
    }
}