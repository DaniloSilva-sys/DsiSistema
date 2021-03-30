using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class FinLancamentoReceberConfiguration : IEntityTypeConfiguration<FinLancamentoReceber>
    {
        public void Configure(EntityTypeBuilder<FinLancamentoReceber> builder)
        {
            builder.ToTable("FINLANCAMENTORECEBER");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdFinDocumentoOrigem);
            builder.Property(x => x.IdCliente);
            builder.Property(x => x.QuantidadeParcela);
            builder.Property(x => x.ValorTotal);
            builder.Property(x => x.ValorAReceber);
            builder.Property(x => x.DataLancamento);
            builder.Property(x => x.NumeroDocumento);
            builder.Property(x => x.PrimeiroVencimento);
            builder.Property(x => x.TaxaComissao);
            builder.Property(x => x.ValorComissao);
            builder.Property(x => x.IntervaloEntreParcelas);
            builder.Property(x => x.CodigoModuloLcto);
            builder.Property(x => x.QuantidadeParcela);
            builder.Property(x => x.QuantidadeParcela);
            builder.Property(x => x.QuantidadeParcela);
            builder.HasMany(x => x.ListaFinParcelaReceber);
        }
    }
}