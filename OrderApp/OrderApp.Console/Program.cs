using OrderApp.Application.Services;
using OrderApp.Domain.Entities;
using OrderApp.Infrastructure.Adapters;

class Program
{
    static void Main(string[] args)
    {
        var order = new Order(1, "Product A", 2);

        var orderRepository = new OrderRepository();
        var emailService = new EmailService();

        var orderService = new OrderService(orderRepository, emailService);
        orderService.ProcessOrder(order, "customer@example.com");

        Console.WriteLine("Order processed and notification sent.");
    }
}