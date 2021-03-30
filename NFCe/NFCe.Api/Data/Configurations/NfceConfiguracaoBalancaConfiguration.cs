using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfceConfiguracaoBalancaConfiguration : IEntityTypeConfiguration<NfceConfiguracaoBalanca>
    {
        public void Configure(EntityTypeBuilder<NfceConfiguracaoBalanca> builder)
        {
            builder.ToTable("NFCECONFIGURACAOBALANCA");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Modelo);
            builder.Property(x => x.Identificador);
            builder.Property(x => x.HandShake);
            builder.Property(x => x.Parity);
            builder.Property(x => x.StopBits);
            builder.Property(x => x.DataBits);
            builder.Property(x => x.BaudRate);
            builder.Property(x => x.Porta);
            builder.Property(x => x.Timeout);
            builder.Property(x => x.TipoConfiguracao);
        }
    }
}