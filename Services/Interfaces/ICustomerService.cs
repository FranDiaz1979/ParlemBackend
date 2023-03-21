using Models;

namespace Services
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        Customer? GetById(int id);
    }
}