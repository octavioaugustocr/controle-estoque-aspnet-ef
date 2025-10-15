using ControleEstoqueAspNetEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ControleEstoqueAspNetEF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>().Property(p => p.Preco).HasColumnType("decimal(18,2)");
        }
    }
}
