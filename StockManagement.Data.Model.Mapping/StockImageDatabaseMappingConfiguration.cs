using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class StockImageDatabaseMappingConfiguration : IEntityTypeConfiguration<StockImage>
    {
        public void Configure(EntityTypeBuilder<StockImage> builder)
        {
            builder.ToTable("StockImage", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Filename).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(entity => entity.Description).HasColumnType("nvarchar").HasMaxLength(500);
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();

            builder.HasOne(entity => entity.StockCard).WithMany(entity=>entity.StockImage).HasForeignKey(entity=>entity.StockCardId);

        }
    }
}
