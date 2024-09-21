using Moq;
using OrderApp.Application.Services;
using OrderApp.Domain.Entities;
using OrderApp.Domain.Ports;

namespace OrderApp.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void ProcessOrder_Should_SaveOrder_And_SendEmail()
        {
            // Arrange
            var order = new Order(1, "Product A", 2);
            var customerEmail = "customer@example.com";

            var mockOrderRepository = new Mock<IOrderRepository>();
            var mockEmailService = new Mock<IEmailService>();

            var orderService = new OrderService(mockOrderRepository.Object, mockEmailService.Object);

            // Act
            orderService.ProcessOrder(order, customerEmail);

            // Assert
            mockOrderRepository.Verify(repo => repo.SaveOrder(order), Times.Once);
            mockEmailService.Verify(service => service.SendEmail(order, customerEmail), Times.Once);
        }
    }
}
