using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfceSangriaConfiguration : IEntityTypeConfiguration<NfceSangria>
    {
        public void Configure(EntityTypeBuilder<NfceSangria> builder)
        {
            builder.ToTable("NFCESANGRIA");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdNfceMovimento);
            builder.Property(x => x.DataSangria);
            builder.Property(x => x.Valor);
            builder.Property(x => x.Observacao);
        }
    }
}