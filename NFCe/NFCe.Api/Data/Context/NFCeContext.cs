using Microsoft.EntityFrameworkCore;
using NFCe.Api.Data.Configurations;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Context
{
    public class NFCeContext : DbContext
    {
        public NFCeContext(DbContextOptions<NFCeContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
        }

        public DbSet<Empresa> Empresa { get; set; }
    }
}
