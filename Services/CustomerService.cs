using Microsoft.EntityFrameworkCore;
using Models;
using SQLiteDatabase;
using System;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ParlemDbContext dbContext;

        public CustomerService(ParlemDbContext dbContext)
        {

            this.dbContext = dbContext;
        }

        public async void Add(Customer customer)
        {
            await dbContext.Customers.AddAsync(customer);
            await dbContext.SaveChangesAsync();
        }

        public Customer? GetById(int id)
        {
            Customer? customer = dbContext.Customers.SingleOrDefault(x=>x.Id==id);
            return customer;
        }
    }
}