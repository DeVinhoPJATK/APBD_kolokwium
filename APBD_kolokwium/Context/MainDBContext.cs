using APBD_kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_kolokwium.Context;

public class MainDBContext : DbContext
{
    public MainDBContext() {}

    public MainDBContext(DbContextOptions options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(("Server=localhost,1433;Database=test_db;User Id=sa;Password=Test1234!;TrustServerCertificate=True;"));
    }
    
    public DbSet<Client> Clients { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Payment> Payments { get; set; }
}
