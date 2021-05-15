using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class StockSupplementTypeDatabaseMappingConfiguration : IEntityTypeConfiguration<StockSupplementType>
    {
        public void Configure(EntityTypeBuilder<StockSupplementType> builder)
        {
            builder.ToTable("StockSupplementType", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Code).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(entity => entity.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(entity => entity.Description).HasColumnType("nvarchar").HasMaxLength(500);
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();
        }
    }
}
