using ECommerceShowcase.Models;

namespace ECommerceShowcase.Data
{
    public class CustomerService
    {
        private readonly List<Customer> _customers = new();
        private readonly Random _rng = new();
        public Customer SaveCustomer(Customer customer)
        {
            customer.CustomerId4Digit = GenerateUnique4DigitId();
            _customers.Add(customer);
            return customer;
        }
        public Customer? GetCustomerById(int id) => _customers.FirstOrDefault(c => c.CustomerId4Digit == id);
        private int GenerateUnique4DigitId()
        {
            int id;
            lock (_customers)
            {
                do
                {
                    id = _rng.Next(1000, 10000);
                } while (_customers.Any(c => c.CustomerId4Digit == id));
            }
            return id;
        }
    }
}
