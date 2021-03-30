using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfcePosicaoComponentesConfiguration : IEntityTypeConfiguration<NfcePosicaoComponentes>
    {
        public void Configure(EntityTypeBuilder<NfcePosicaoComponentes> builder)
        {
            builder.ToTable("NFCEPOSICAOCOMPONENTES");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdNfceResolucao);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Altura);
            builder.Property(x => x.Largura);
            builder.Property(x => x.Topo);
            builder.Property(x => x.Esquerda);
            builder.Property(x => x.TamanhoFonte);
            builder.Property(x => x.Texto);
        }
    }
}