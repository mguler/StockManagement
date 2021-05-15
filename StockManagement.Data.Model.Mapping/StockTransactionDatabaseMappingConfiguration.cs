using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class StockTransactionDatabaseMappingConfiguration : IEntityTypeConfiguration<StockTransaction>
    {
        public void Configure(EntityTypeBuilder<StockTransaction> builder)
        {
            builder.ToTable("StockTransaction", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Created).IsRequired();
            builder.Property(entity => entity.TransactionDate).IsRequired();
            builder.Property(entity => entity.TrackingNumber).IsRequired();
            builder.Property(entity => entity.Inbound).IsRequired();
            builder.Property(entity => entity.Outbound).IsRequired();
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();

            builder.HasOne(entity => entity.InboundCurrentAccount).WithMany().HasForeignKey(entity => entity.InboundCurrentAccountId).OnDelete( DeleteBehavior.NoAction);
            builder.HasOne(entity => entity.OutboundCurrentAccount).WithMany().HasForeignKey(entity => entity.OutboundCurrentAccountId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(entity => entity.StockCard).WithMany().HasForeignKey(entity => entity.StockCardId);
            builder.HasOne(entity => entity.Warehouse).WithMany().HasForeignKey(entity => entity.WarehouseId);
        }
    }
}
