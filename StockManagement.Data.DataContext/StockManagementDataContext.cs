using Microsoft.EntityFrameworkCore;
using StockManagement.Data.Model.Mapping;

namespace StockManagement.Data.DataContext
{
    public class StockManagementDataContext:DbContext
    {
        public StockManagementDataContext(DbContextOptions options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CurrentAccountDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialCodeDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new MeasureUnitDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new StockAlertLevelDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new StockBalanceDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new StockCardDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new StockConsumptionTypeDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new StockImageDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new StockSupplementTypeDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new StockTransactionDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new StockValorDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new UserDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new UserWarehouseAssignmentDatabaseMappingConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseDatabaseMappingConfiguration());
        }
    }
}
