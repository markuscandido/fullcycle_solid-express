using OrderApp.Domain.Entities;
using OrderApp.Domain.Ports;

namespace OrderApp.Application.Services
{
    public class OrderService(IOrderRepository orderRepository, IEmailService emailService)
    {
        public void ProcessOrder(Order order, string customerEmail)
        {
            orderRepository.SaveOrder(order);
            emailService.SendEmail(order, customerEmail);
        }
    }
}
