using Microsoft.EntityFrameworkCore;

namespace Uygulama.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
