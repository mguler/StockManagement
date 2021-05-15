namespace StockManagement.Data.Model
{
    public class StockAlertLevel
    {
        public int Id { get; set; }
        public int StockCardId { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }
        public string AlertMessage { get; set; }
        public string ColorCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual StockCard StockCard { get; set; }
    }
}
