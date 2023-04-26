using CrudOperation.Models.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace CrudOperation.data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        { 

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
