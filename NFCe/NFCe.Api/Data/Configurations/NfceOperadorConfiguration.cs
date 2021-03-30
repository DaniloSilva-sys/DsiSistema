using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class NfceOperadorConfiguration : IEntityTypeConfiguration<NfceOperador>
    {
        public void Configure(EntityTypeBuilder<NfceOperador> builder)
        {
            builder.ToTable("NFCEOPERADOR");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Login);
            builder.Property(x => x.Senha);
            builder.Property(x => x.NivelAutorizacao);
        }
    }
}