using Microsoft.AspNetCore.Mvc;
using Services;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly IProductService productService;

        public CustomersController(ICustomerService customerService, IProductService productService)
        {
            this.customerService = customerService;
            this.productService = productService;
        }

        //// GET: api/Customers
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/Customers/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var customer = customerService.GetById(id);
            string json = JsonSerializer.Serialize(customer);
            return Ok(json);
        }

        // GET api/Customers/5/Products
        [HttpGet("{id}/Products")]
        public ActionResult GetProducts(int id)
        {
            var products = productService.GetCustomerList(id);
            string json = JsonSerializer.Serialize(products);            
            return Ok(json);
        }

        //// POST api/Customers
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/Customers/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/Customers/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
