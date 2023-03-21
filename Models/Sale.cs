using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public DateTime SoldAt { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
