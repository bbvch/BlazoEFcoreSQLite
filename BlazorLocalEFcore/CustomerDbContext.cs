using Microsoft.EntityFrameworkCore;

namespace BlazorLocalEFcore
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = default!;

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>().HasIndex(x => x.FullName);
            modelBuilder.Entity<Customer>().Property(x => x.FullName).UseCollation("nocase");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.LogTo(Console.WriteLine, LogLevel.Warning)
                    .EnableDetailedErrors()
                    .EnableSensitiveDataLogging(true);
        }
    }
}
