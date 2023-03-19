using Models;

namespace Services
{
    public interface IProductService
    {
        void Add(Product product);
        IEnumerable<Product> GetCustomerList(int customerId);
    }
}