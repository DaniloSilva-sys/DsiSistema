using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class FinParcelaReceberConfiguration : IEntityTypeConfiguration<FinParcelaReceber>
    {
        public void Configure(EntityTypeBuilder<FinParcelaReceber> builder)
        {
            builder.ToTable("FINPARCELARECEBER");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdContaCaixa);
            builder.Property(x => x.IdFinLancamentoReceber);
            builder.Property(x => x.NumeroParcela);
            builder.Property(x => x.DataEmissao);
            builder.Property(x => x.DataVencimento);
            builder.Property(x => x.DescontoAte);
            builder.Property(x => x.Valor);
            builder.Property(x => x.TaxaJuro);
            builder.Property(x => x.TaxaMulta);
            builder.Property(x => x.TaxaDesconto);
            builder.Property(x => x.ValorJuro);
            builder.Property(x => x.ValorMulta);
            builder.Property(x => x.ValorDesconto);
            builder.Property(x => x.EmitiuBoleto);
            builder.Property(x => x.BoletoNossoNumero);
        }
    }
}