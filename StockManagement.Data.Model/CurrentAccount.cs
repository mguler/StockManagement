namespace StockManagement.Data.Model
{
    public class CurrentAccount
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
