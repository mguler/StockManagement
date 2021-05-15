using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class StockCardDatabaseMappingConfiguration : IEntityTypeConfiguration<StockCard>
    {
        public void Configure(EntityTypeBuilder<StockCard> builder)
        {
            builder.ToTable("StockCard", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Barcode).HasColumnType("nvarchar").HasMaxLength(20);
            builder.Property(entity => entity.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(entity => entity.Description).HasColumnType("nvarchar").HasMaxLength(500);
            builder.Property(entity => entity.WarehouseId).IsRequired();
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();

            builder.HasOne(entity => entity.MaterialCode).WithMany(entity => entity.StockCard).HasForeignKey(entity => entity.MaterialCodeId);
            builder.HasOne(entity => entity.MeasureUnit).WithMany().HasForeignKey(entity => entity.MeasureUnitId);
        }
    }
}
