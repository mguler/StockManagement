using System.Collections.Generic;

namespace StockManagement.Data.Model
{
    public class StockCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public int MaterialCodeId { get; set; }
        public int MeasureUnitId { get; set; }
        public int WarehouseId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual List<StockImage> StockImage { get; set; }
        public virtual List<StockAlertLevel> StockAlertLevel { get; set; }
        public virtual MaterialCode MaterialCode { get; set; }
        public virtual MeasureUnit MeasureUnit { get; set; }


    }
}
