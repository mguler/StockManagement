using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class StockBalanceDatabaseMappingConfiguration : IEntityTypeConfiguration<StockBalance>
    {
        public void Configure(EntityTypeBuilder<StockBalance> builder)
        {
            builder.ToTable("StockBalance", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Created).IsRequired();
            builder.Property(entity => entity.WarehouseId).IsRequired();
            builder.Property(entity => entity.TrackingNumber).IsRequired();
            builder.Property(entity => entity.Inbound).IsRequired();
            builder.Property(entity => entity.Outbound).IsRequired();
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();

            builder.HasOne(entity => entity.StockCard).WithMany().HasForeignKey(entity => entity.StockCardId);
            builder.HasOne(entity => entity.Warehouse).WithMany().HasForeignKey(entity => entity.WarehouseId);
        }
    }
}
