using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;

namespace NFCe.Api.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CLIENTE");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdTributOperacaoFiscal);
            builder.Property(x => x.IdPessoa);
            builder.Property(x => x.IdAtividadeForCli);
            builder.Property(x => x.IdSituacaoForCli);
            builder.Property(x => x.Desde);
            builder.Property(x => x.DataCadastro);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Cpf);
            builder.Property(x => x.Rg);
            builder.Property(x => x.Endereco);
            builder.Property(x => x.Observacao);
            builder.Property(x => x.ContaTomador);
            builder.Property(x => x.GeraFinanceiro);
            builder.Property(x => x.IndicadorPreco);
            builder.Property(x => x.PorcentoDesconto);
            builder.Property(x => x.FormaDesconto);
            builder.Property(x => x.LimiteCredito);
            builder.Property(x => x.TipoFrete);
            builder.Property(x => x.ClassificacaoContabilConta);
            builder.Property(x => x.IdConvenio);
        }
    }
}