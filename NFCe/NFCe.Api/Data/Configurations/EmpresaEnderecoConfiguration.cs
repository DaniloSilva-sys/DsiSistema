using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class EmpresaEnderecoConfiguration : IEntityTypeConfiguration<EmpresaEndereco>
    {
        public void Configure(EntityTypeBuilder<EmpresaEndereco> builder)
        {
            builder.ToTable("EMPRESAENDERECO");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Logradouro);
            builder.Property(x => x.Numero);
            builder.Property(x => x.Bairro);
            builder.Property(x => x.Cidade);
            builder.Property(x => x.Cep);
            builder.Property(x => x.Fone);
            builder.Property(x => x.MunicipioIbge);
            builder.Property(x => x.Uf);
            builder.Property(x => x.Principal);
            builder.Property(x => x.Entrega);
            builder.Property(x => x.Cobranca);
            builder.Property(x => x.Correspondencia);
        }
    }
}
