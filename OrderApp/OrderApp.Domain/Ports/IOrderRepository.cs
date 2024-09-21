namespace OrderApp.Domain.Ports
{
    public interface IOrderRepository
    {
        void SaveOrder(Entities.Order order);
    }
}
