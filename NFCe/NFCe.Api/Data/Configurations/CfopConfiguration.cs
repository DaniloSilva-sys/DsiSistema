using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class CfopConfiguration : IEntityTypeConfiguration<Cfop>
    {
        public void Configure(EntityTypeBuilder<Cfop> builder)
        {
            builder.ToTable("CFOP");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Numero);
            builder.Property(x => x.Descricao);
            builder.Property(x => x.Aplicacao);
        }
    }
}