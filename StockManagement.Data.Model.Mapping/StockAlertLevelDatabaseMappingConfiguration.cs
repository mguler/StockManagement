using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class StockAlertLevelDatabaseMappingConfiguration : IEntityTypeConfiguration<StockAlertLevel>
    {
        public void Configure(EntityTypeBuilder<StockAlertLevel> builder)
        {
            builder.ToTable("StockAlertLevel", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Amount).IsRequired();
            builder.Property(entity => entity.Name).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(entity => entity.AlertMessage).HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(entity => entity.ColorCode).HasMaxLength(10).IsRequired();
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();
            builder.HasOne(entity => entity.StockCard).WithMany(entity => entity.StockAlertLevel).HasForeignKey(entity => entity.StockCardId);
        }
    }
}
