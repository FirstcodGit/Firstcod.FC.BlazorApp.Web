using Firstcod.FC.Provider.Models;
using Microsoft.EntityFrameworkCore;

namespace Firstcod.FC.Provider
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Kendo> Kendos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable($"App{nameof(this.Users)}");
            builder.Entity<User>(entity => { entity.HasIndex(t => t.EmailAddress).IsUnique(); });

            builder.Entity<Kendo>().ToTable($"App{nameof(this.Kendos)}");
        }
    }
}
