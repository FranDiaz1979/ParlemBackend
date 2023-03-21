using Microsoft.EntityFrameworkCore;
using SQLiteDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ProductServiceTests
    {
        private ParlemDbContext dbContext;
        private string databaseName = "./parlem.db";

        [SetUp]
        public void Setup()
        {
            ParlemDatabase.Create(databaseName);

            var optionsBuilder = new DbContextOptionsBuilder<ParlemDbContext>();
            optionsBuilder.UseSqlite("Data Source=" + databaseName);
            var options = optionsBuilder.Options;

            dbContext = new ParlemDbContext(options);
        }

        [Test]
        public void Tiene2Registros()
        {
            var cuantos = dbContext.Products.Count();

            Assert.That(cuantos, Is.EqualTo(2));
        }
    }
}
