using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class StockValorDatabaseMappingConfiguration : IEntityTypeConfiguration<StockValor>
    {
        public void Configure(EntityTypeBuilder<StockValor> builder)
        {
            builder.ToTable("StockValor", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Begin).IsRequired();
            builder.Property(entity => entity.End);
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
