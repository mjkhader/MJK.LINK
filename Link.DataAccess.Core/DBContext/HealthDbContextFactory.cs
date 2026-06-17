using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Link.DataAccess.DBContext
{
    public class HealthDbContextFactory : IDesignTimeDbContextFactory<HealthDbContext>
    {
        public HealthDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HealthDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HealthyEntity;Trusted_Connection=true;");

            return new HealthDbContext(optionsBuilder.Options);
        }
    }
}
