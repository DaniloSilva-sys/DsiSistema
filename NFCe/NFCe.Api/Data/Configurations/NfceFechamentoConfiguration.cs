using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfceFechamentoConfiguration : IEntityTypeConfiguration<NfceFechamento>
    {
        public void Configure(EntityTypeBuilder<NfceFechamento> builder)
        {
            builder.ToTable("NFCEFECHAMENTO");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdNfceMovimento);
            builder.Property(x => x.TipoPagamento);
            builder.Property(x => x.Valor);
        }
    }
}