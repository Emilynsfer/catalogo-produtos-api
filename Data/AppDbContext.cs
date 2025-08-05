using Microsoft.EntityFrameworkCore;
using CatalogoProdutosMinimalAPI.Models;

namespace CatalogoProdutosMinimalAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
