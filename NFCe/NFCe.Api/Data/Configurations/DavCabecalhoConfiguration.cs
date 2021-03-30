using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class DavCabecalhoConfiguration : IEntityTypeConfiguration<DavCabecalho>
    {
        public void Configure(EntityTypeBuilder<DavCabecalho> builder)
        {
            builder.ToTable("DAVCABECALHO");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.NumeroDav);
            builder.Property(x => x.NumeroEcf);
            builder.Property(x => x.Ccf);
            builder.Property(x => x.Coo);
            builder.Property(x => x.NomeDestinatario);
            builder.Property(x => x.CpfCnpjDestinatario);
            builder.Property(x => x.DataEmissao);
            builder.Property(x => x.HoraEmissao);
            builder.Property(x => x.Situacao);
            builder.Property(x => x.Situacao);
            builder.Property(x => x.TaxaAcrescimo);
            builder.Property(x => x.Acrescimo);
            builder.Property(x => x.TaxaDesconto);
            builder.Property(x => x.Desconto);
            builder.Property(x => x.Subtotal);
            builder.Property(x => x.Valor);
            builder.Property(x => x.Impresso);
            builder.Property(x => x.Logss);
            builder.HasMany(x => x.ListaDavDetalhe);//configurar o muitos pra (um ou muitos)
            builder.HasOne(x => x.Empresa);
        }
    }
}