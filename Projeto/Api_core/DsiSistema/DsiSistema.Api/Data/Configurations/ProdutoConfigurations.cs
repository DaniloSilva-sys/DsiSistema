using DsiSistema.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DsiSistema.Api.Data.Configurations
{
    public class ProdutoConfigurations : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");

            builder.HasKey(x => new { x.ControleInterno, x.CodigoBarra });

            builder.Property(x => x.ControleInterno)
                .HasColumnName("ID_INTERNO")
                .HasMaxLength(13);

            builder.Property(x => x.CodigoBarra)
                .HasColumnName("COD_BARRA")
                .HasMaxLength(13);

            builder.Property(x => x.Descricao)
                .HasMaxLength(50)
                .IsRequired();


            //exemple 1 para muitos
            //builder.HasOne(x => x.CodigoBarra).WithMany().HasForeignKey("ID_QLQRCOISA");
        }
    }
}