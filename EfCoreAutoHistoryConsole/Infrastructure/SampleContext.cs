using Microsoft.EntityFrameworkCore;

namespace EfCoreAutoHistoryConsole.Infrastructure
{
    public class SampleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"enter connection string");
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder.EnableAutoHistory(null));//changeMaxLength Varsayılan 2048
        }
    }
}
