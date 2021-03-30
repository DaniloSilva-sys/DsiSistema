using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFCe.Api.Data.Configurations
{
    public class NfceConfiguracaoConfiguration : IEntityTypeConfiguration<NfceConfiguracao>
    {
        public void Configure(EntityTypeBuilder<NfceConfiguracao> builder)
        {
            builder.ToTable("NFCECONFIGURACAO");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.MensagemCupom);
            builder.Property(x => x.TituloTelaCaixa);
            builder.Property(x => x.CaminhoImagensProdutos);
            builder.Property(x => x.CaminhoImagensMarketing);
            builder.Property(x => x.CaminhoImagensLayout);
            builder.Property(x => x.CorJanelasInternas);
            builder.Property(x => x.MarketingAtivo);
            builder.Property(x => x.Cfop);
            builder.Property(x => x.DecimaisQuantidade);
            builder.Property(x => x.DecimaisValor);
            builder.Property(x => x.QuantidadeMaximaParcela);
            builder.Property(x => x.ImprimeParcela);

            /*

        public NfceResolucao NfceResolucao { get; set; }
        public NfceCaixa NfceCaixa { get; set; }
        public Empresa Empresa { get; set; }
        public NfceConfiguracaoBalanca NfceConfiguracaoBalanca { get; set; }
        public NfceConfiguracaoLeitorSer NfceConfiguracaoLeitorSer { get; set; }
             */
        }
    }
}
