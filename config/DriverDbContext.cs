using Microsoft.EntityFrameworkCore;
using fleetmanagement.entities;

namespace fleetmanagement.config;

public class DriverDbContext : DbContext
{
    public DriverDbContext(DbContextOptions<DriverDbContext> options) : base(options) { }

    public DbSet<Driver> Drivers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Driver>().HasKey(t => t.Id);
        base.OnModelCreating(modelBuilder);
    }
}
