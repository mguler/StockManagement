using System.Collections.Generic;

namespace StockManagement.Data.Model
{
    public class UserWarehouseAssignment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WarehouseId{ get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual User User { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
