using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace myapp.DataContext
{
    public class DesignTimeMasterDbContextFactory : IDesignTimeDbContextFactory<StoreProcedureMigrationDbContext>
    {
        public StoreProcedureMigrationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();
            var builder = new DbContextOptionsBuilder<StoreProcedureMigrationDbContext>();
            var connectionString = configuration.GetConnectionString("SietapDatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new StoreProcedureMigrationDbContext(builder.Options);
        }
    }
    public class StoreProcedureMigrationDbContext : DbContext
    {
        public StoreProcedureMigrationDbContext(DbContextOptions<StoreProcedureMigrationDbContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
         
        }
    }
}