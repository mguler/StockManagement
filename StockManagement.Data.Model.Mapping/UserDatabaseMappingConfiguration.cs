using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class UserDatabaseMappingConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Username).IsRequired();
            builder.Property(entity => entity.Password);
            builder.Property(entity => entity.Fullname).IsRequired();
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();
        }
    }
}
