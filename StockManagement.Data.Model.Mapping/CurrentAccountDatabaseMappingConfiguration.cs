using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class CurrentAccountDatabaseMappingConfiguration : IEntityTypeConfiguration<CurrentAccount>
    {
        public void Configure(EntityTypeBuilder<CurrentAccount> builder)
        {
            builder.ToTable("CurrentAccount", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Title).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.Property(entity => entity.ContactPerson).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(entity => entity.Address).HasColumnType("nvarchar").HasMaxLength(500);
            builder.Property(entity => entity.Email).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(entity => entity.PhoneNumber).HasColumnType("nvarchar").HasMaxLength(20);
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();
        }
    }
}
