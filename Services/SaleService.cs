using SQLiteDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class SaleService : ISaleService
    {
        private readonly ParlemDbContext dbContext;

        public SaleService(ParlemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async void Add(Sale sale)
        {
            await dbContext.Sales.AddAsync(sale);
            await dbContext.SaveChangesAsync();
        }

        public IEnumerable<Sale> GetListByCustomerId(int customerId)
        {
            IEnumerable<Sale> sales = dbContext.Sales.Where(x => x.CustomerId == customerId);
            return sales;
        }
    }
}
