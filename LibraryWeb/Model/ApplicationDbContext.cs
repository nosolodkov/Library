using Microsoft.EntityFrameworkCore;

namespace LibraryWeb.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
