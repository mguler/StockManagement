using System.Collections.Generic;

namespace StockManagement.Data.Model
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual List<UserWarehouseAssignment> UserWarehouseAssignment { get; set; }
    }
}
