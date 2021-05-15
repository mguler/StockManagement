using System;

namespace StockManagement.Data.Model
{
    public class StockBalance
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int TrackingNumber { get; set; } 
        public decimal Inbound { get; set; }
        public decimal Outbound { get; set; }
        public int StockCardId { get; set; }
        public int StockTransactionId { get; set; }
        public int WarehouseId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual StockCard StockCard { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
