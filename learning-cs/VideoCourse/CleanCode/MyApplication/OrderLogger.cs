using System;

namespace MyApplication;

public class OrderLogger
{
    public void LogOrder(Order order)
    {
        // Log the order to a file
        Console.WriteLine($"Order {order.Id} logged.");
    }
}