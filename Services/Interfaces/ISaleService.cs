using Models;

namespace Services
{
    public interface ISaleService
    {
        void Add(Sale sale);
        IEnumerable<Sale> GetListByCustomerId(int customerId);
    }
}