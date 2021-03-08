using DsiSistema.Api.Data.Configurations;
using DsiSistema.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DsiSistema.Api.Data
{
    public class DsiContext : DbContext
    {
        public DsiContext(DbContextOptions<DsiContext> options) 
            : base(options)
        { }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoConfigurations());

            base.OnModelCreating(modelBuilder);
        }
    }
}