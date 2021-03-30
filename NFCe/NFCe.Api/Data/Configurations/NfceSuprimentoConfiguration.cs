using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfceSuprimentoConfiguration : IEntityTypeConfiguration<NfceSuprimento>
    {
        public void Configure(EntityTypeBuilder<NfceSuprimento> builder)
        {
            builder.ToTable("NFCESUPRIMENTO");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdNfceMovimento);
            builder.Property(x => x.DataSuprimento);
            builder.Property(x => x.Valor);
            builder.Property(x => x.Observacao);
        }
    }
}