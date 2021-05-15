using System.Collections.Generic;

namespace StockManagement.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname{ get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual List<UserWarehouseAssignment> UserWarehouseAssignment { get; set; }
    }
}
