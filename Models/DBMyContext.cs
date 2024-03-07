using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FPT_JOB.Models;

namespace FPT_JOB.Models
{
    public class DBMyContext : IdentityDbContext
    {
        public DBMyContext(DbContextOptions<DBMyContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<FPT_JOB.Models.Profile> Profile { get; set; } = default!;
    }
}
