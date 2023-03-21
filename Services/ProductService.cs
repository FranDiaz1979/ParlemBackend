using Models;
using SQLiteDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly ParlemDbContext dbContext;

        public ProductService(ParlemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async void Add(Product product)
        {
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
        }

        public IEnumerable<Product> GetListByCustomerId(int customerId)
        {
            IEnumerable<Product> products = dbContext.Sales.Where(x => x.CustomerId == customerId).Select(x=>x.Product);
            return products;
        }
    }
}
