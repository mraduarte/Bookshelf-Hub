using bookshelfhub.Models;
using Microsoft.EntityFrameworkCore;

namespace bookshelfhub.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Login> Users { get; set; }
    }
}
