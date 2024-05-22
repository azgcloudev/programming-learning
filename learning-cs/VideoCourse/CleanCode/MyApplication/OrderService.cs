using System.Collections.Generic;

namespace MyApplication;

/*
 * SRP = SINGLE RESPONSABILITY:
 * Says that one class should only perform one action.
 *
 * In this case Logging and notify customer are not related to Orders directly.
 */

public class OrderService
{
    private List<Order> orders = new List<Order>();
    private OrderLogger orderLogger = new OrderLogger();
    private OrderNotifier orderNotifier = new OrderNotifier();

    public void AddOrder(Order order)
    {
        orders.Add(order);
        orderLogger.LogOrder(order);
        orderNotifier.NotifyCustomer(order);
    }
}