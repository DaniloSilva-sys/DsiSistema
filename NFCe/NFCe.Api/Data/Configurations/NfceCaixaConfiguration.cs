using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfceCaixaConfiguration : IEntityTypeConfiguration<NfceCaixa>
    {
        public void Configure(EntityTypeBuilder<NfceCaixa> builder)
        {
            builder.ToTable("NFCECAIXA");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.Property(x => x.DataCadastro);
        }
    }
}