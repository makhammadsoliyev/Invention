using Invention.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Invention.DataAccess.Contexts;

public class InventionDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=127.0.0.1;Port=5432;Database=InventionDB;User Id=postgres;Password=1510;";
        optionsBuilder.UseNpgsql(connectionString);
    }

    public DbSet<Market> Markets { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<WarehouseOperation> WarehouseOperations { get; set; }
}
