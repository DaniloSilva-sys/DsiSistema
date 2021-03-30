using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfceConfiguracaoLeitorSerConfiguration : IEntityTypeConfiguration<NfceConfiguracaoLeitorSer>
    {
        public void Configure(EntityTypeBuilder<NfceConfiguracaoLeitorSer> builder)
        {
            builder.ToTable("NFCECONFIGURACAOLEITORSER");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Usa);
            builder.Property(x => x.Porta);
            builder.Property(x => x.Baud);
            builder.Property(x => x.HandShake);
            builder.Property(x => x.Parity);
            builder.Property(x => x.StopBits);
            builder.Property(x => x.DataBits);
            builder.Property(x => x.Intervalo);
            builder.Property(x => x.UsarFila);
            builder.Property(x => x.HardFlow);
            builder.Property(x => x.SoftFlow);
            builder.Property(x => x.Sufixo);
            builder.Property(x => x.ExcluirSufixo);
        }
    }
}