using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagement.Data.Model.Mapping
{
    public class UserWarehouseAssignmentDatabaseMappingConfiguration : IEntityTypeConfiguration<UserWarehouseAssignment>
    {
        public void Configure(EntityTypeBuilder<UserWarehouseAssignment> builder)
        {
            builder.ToTable("UserWarehouseAssignment", "StockManagement");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.IsActive).IsRequired();
            builder.Property(entity => entity.IsDeleted).IsRequired();

            builder.HasOne(entity => entity.Warehouse).WithMany(entity=>entity.UserWarehouseAssignment).HasForeignKey(entity => entity.WarehouseId);
            builder.HasOne(entity => entity.User).WithMany(entity => entity.UserWarehouseAssignment).HasForeignKey(entity => entity.UserId);
        }
    }
}
