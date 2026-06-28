using ECommerceShowcase.Models;

namespace ECommerceShowcase.Data
{
    public class OrderService
    {
        private readonly List<Order> _orders = new();
        public Order PlaceOrder(Order order)
        {
            _orders.Add(order);
            return order;
        }
        public Order? GetOrderById(System.Guid id) => _orders.FirstOrDefault(o => o.Id == id);
        public IEnumerable<Order> GetAllOrders() => _orders;
    }
}
