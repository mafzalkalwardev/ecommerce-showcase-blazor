namespace ECommerceShowcase.Models
{
    public class Order
    {
        public System.Guid Id { get; set; } = System.Guid.NewGuid();
        public int CustomerId4Digit { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal TotalPrice => UnitPrice * Quantity;
        public System.DateTime OrderedAt { get; set; } = System.DateTime.UtcNow;
    }
}
