using System;

namespace StockManagement.Data.Model
{
    public class StockTransaction
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime TransactionDate { get; set; }
        public int StockCardId { get; set; }
        public int WarehouseId { get; set; }
        public int OutboundCurrentAccountId { get; set; }
        public int InboundCurrentAccountId { get; set; }
        public int TrackingNumber { get; set; }
        public decimal Inbound { get; set; }
        public decimal Outbound { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual StockCard StockCard { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual CurrentAccount OutboundCurrentAccount { get; set; }
        public virtual CurrentAccount InboundCurrentAccount { get; set; }
    }
}
