namespace Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string DocType { get; set; }
        public string DocNum { get; set; }
        public string Email { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Phone { get; set; }

        public Customer()
        {
            DocType = string.Empty;
            DocNum = string.Empty;
            Email = string.Empty;
            GivenName = string.Empty;
            FamilyName = string.Empty;
            Phone = string.Empty;
        }
    }
}