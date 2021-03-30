using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class DavDetalheConfiguration : IEntityTypeConfiguration<DavDetalhe>
    {
        public void Configure(EntityTypeBuilder<DavDetalhe> builder)
        {
            builder.ToTable("DAVDETALHE");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdDavCabecalho);
            builder.Property(x => x.NumeroDav);
            builder.Property(x => x.DataEmissao);
            builder.Property(x => x.Item);
            builder.Property(x => x.Quantidade);
            builder.Property(x => x.ValorUnitario);
            builder.Property(x => x.ValorTotal);
            builder.Property(x => x.Cancelado);
            builder.Property(x => x.MesclaProduto);
            builder.Property(x => x.GtinProduto);
            builder.Property(x => x.NomeProduto);
            builder.Property(x => x.UnidadeProduto);
            builder.Property(x => x.TotalizadorParcial);
            builder.Property(x => x.Logss);

            builder.HasOne(x => x.Produto);
        }
    }
}