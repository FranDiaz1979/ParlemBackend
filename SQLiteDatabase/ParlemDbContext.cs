using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLiteDatabase
{
    public class ParlemDbContext : DbContext 
    {

        public ParlemDbContext(DbContextOptions<ParlemDbContext> options)
            : base(options)
        {
            //SQLitePCL.Batteries.Init();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
