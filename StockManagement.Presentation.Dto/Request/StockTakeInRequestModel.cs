using System;

namespace StockManagement.Presentation.Dto.Request
{
    public class StockTakeIn
    {
        public int StockCardId { get; set; }
        public int CurrentAccountId { get; set; }
        public decimal Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public int Tax { get; set; }


    }
}
