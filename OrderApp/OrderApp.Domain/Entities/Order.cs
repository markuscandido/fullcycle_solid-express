namespace OrderApp.Domain.Entities
{
    public class Order(int id, string productName, int quantity)
    {
        public int Id { get; set; } = id;
        public string ProductName { get; set; } = productName;
        public int Quantity { get; set; } = quantity;
    }
}
