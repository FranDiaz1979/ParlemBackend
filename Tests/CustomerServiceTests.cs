using Microsoft.EntityFrameworkCore;
using SQLiteDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class CustomerServiceTests
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
        public void Tiene3Registros()
        {
            var cuantos = dbContext.Customers.Count();

            Assert.That(cuantos, Is.EqualTo(3));
        }

        [Test]
        public void ComprobarRegistroConId1()
        {
            var customer = dbContext.Customers.Find(1);

            Assert.That(customer, Is.Not.Null);
            Assert.That(customer.DocType, Is.EqualTo("nif"));
            Assert.That(customer.DocNum, Is.EqualTo("11223344E"));
            Assert.That(customer.Email, Is.EqualTo("it@parlem.com"));
            Assert.That(customer.GivenName, Is.EqualTo("Enriqueta"));
            Assert.That(customer.FamilyName, Is.EqualTo("Parlem"));
            Assert.That(customer.Phone, Is.EqualTo("668668668"));
        }

        [Test]
        public void ComprobarRegistroConId4NoExiste()
        {
            var customer = dbContext.Customers.Find(4);

            Assert.That(customer, Is.Null);
        }
    }
}
