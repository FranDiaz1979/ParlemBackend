namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Terminal { get; set; }
        public DateTime SoldAt { get; set; }
        public int CustomerId { get; set; }

        public Product()
        {
            Name = string.Empty;
            Type = string.Empty;
        }
    }
}
