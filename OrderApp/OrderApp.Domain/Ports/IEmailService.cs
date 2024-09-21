namespace OrderApp.Domain.Ports
{
    public interface IEmailService
    {
        void SendEmail(Entities.Order order, string email);
    }
}
