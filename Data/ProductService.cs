using ECommerceShowcase.Models;

namespace ECommerceShowcase.Data
{
    public class ProductService
    {
        private List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Wireless Earbuds", ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=400", Price = 2500 },
            new Product { Id = 2, Name = "Smart Watch", ImageUrl = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=400", Price = 4500 },
            new Product { Id = 3, Name = "Bluetooth Speaker", ImageUrl = "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?w=400", Price = 3200 },
        };

        public IEnumerable<Product> GetProducts() => _products;

        public Product? GetProductById(int id) =>
            _products.FirstOrDefault(p => p.Id == id);
    }
}
