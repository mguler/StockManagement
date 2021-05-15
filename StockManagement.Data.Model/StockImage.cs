namespace StockManagement.Data.Model
{
    public class StockImage
    {
        public int Id { get; set; }
        public int StockCardId { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual StockCard StockCard { get; set; }
    }
}
