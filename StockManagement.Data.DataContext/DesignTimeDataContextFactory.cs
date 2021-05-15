using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Data.DataContext
{

public class DesignTimeDataContextFactory : IDesignTimeDbContextFactory<StockManagementDataContext>
    {

        public DesignTimeDataContextFactory()
        {
        }

        public StockManagementDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StockManagementDataContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Database=StockManagement;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.EnableSensitiveDataLogging();

            return new StockManagementDataContext(optionsBuilder.Options);

        }
    }
}
