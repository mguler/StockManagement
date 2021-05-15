using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class MeasureUnitDatabaseMappingConfiguration : IEntityTypeConfiguration<MeasureUnit>
    {
        public void Configure(EntityTypeBuilder<MeasureUnit> builder)
        {
            builder.ToTable("MeasureUnit", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Code).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(entity => entity.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(entity => entity.Description).HasColumnType("nvarchar").HasMaxLength(500);
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();
        }
    }
}
