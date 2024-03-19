using Microsoft.EntityFrameworkCore;
using myapp.DataContext.DataModels.General;

namespace myapp.DataContext
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Persons> Persons {get;set;}
    }
}