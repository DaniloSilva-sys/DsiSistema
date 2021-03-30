using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("EMPRESA");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.RazaoSocial)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.NomeFantasia)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Cnpj)
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(x => x.InscricaoEstadual)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.InscricaoEstadualSt)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.InscricaoMunicipal)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.InscricaoJuntaComercial)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.DataInscJuntaComercial);

            builder.Property(x => x.Tipo)
                .IsRequired();

            builder.Property(x => x.DataCadastro);

            builder.Property(x => x.DataInicioAtividades);

            builder.Property(x => x.Suframa)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.ImagemLogotipo);

            builder.Property(x => x.Crt)
                .IsRequired();

            builder.Property(x => x.TipoRegime);
                    
            builder.Property(x => x.AliquotaPis);
                    
            builder.Property(x => x.Contato);
                    
            builder.Property(x => x.AliquotaCofins);
                    
            builder.Property(x => x.CodigoIbgeCidade);
                    
            builder.Property(x => x.CodigoIbgeUf);
                    
            builder.Property(x => x.CodigoTerceiros);
                    
            builder.Property(x => x.CodigoGps);
                    
            builder.Property(x => x.AliquotaSat);
                    
            builder.Property(x => x.Cei);
                    
            builder.Property(x => x.CodigoCnaePrincipal);
                    
            builder.Property(x => x.TipoControleEstoque);

            builder.HasOne(x => x.Endereco);
        }
    }
}
