using OrderApp.Domain.Entities;
using OrderApp.Domain.Ports;

namespace OrderApp.Infrastructure.Adapters
{
    public class OrderRepository : IOrderRepository
    {
        public void SaveOrder(Order order)
        {
            // Simula a persistência de um pedido
            System.Console.WriteLine($"Order {order.Id} saved.");
        }
    }
}
