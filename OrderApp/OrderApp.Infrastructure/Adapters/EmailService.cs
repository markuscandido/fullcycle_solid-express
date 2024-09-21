using OrderApp.Domain.Entities;
using OrderApp.Domain.Ports;

namespace OrderApp.Infrastructure.Adapters
{
    public class EmailService : IEmailService
    {
        public void SendEmail(Order order, string email)
        {
            // Simula o envio de um email
            System.Console.WriteLine($"Email sent to {email} for Order {order.Id}.");
        }
    }
}
