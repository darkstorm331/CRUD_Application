using Microsoft.EntityFrameworkCore;

namespace CRUD_Application
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}