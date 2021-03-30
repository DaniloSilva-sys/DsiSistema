using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfceResolucaoConfiguration : IEntityTypeConfiguration<NfceResolucao>
    {
        public void Configure(EntityTypeBuilder<NfceResolucao> builder)
        {
            builder.ToTable("NFCERESOLUCAO");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.ResolucaoTela);
            builder.Property(x => x.Largura);
            builder.Property(x => x.Altura);
            builder.Property(x => x.ImagemTela);
            builder.Property(x => x.ImagemMenu);
            builder.Property(x => x.ImagemSubmenu);

            /*
        public IList<NfcePosicaoComponentes> ListaNfcePosicaoComponentes { get; set; }
             */
        }
    }
}