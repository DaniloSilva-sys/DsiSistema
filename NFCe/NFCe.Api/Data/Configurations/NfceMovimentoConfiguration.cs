using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFCe.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFCe.Api.Data.Configurations
{
    public class NfceMovimentoConfiguration : IEntityTypeConfiguration<NfceMovimento>
    {
        public void Configure(EntityTypeBuilder<NfceMovimento> builder)
        {
            builder.ToTable("NFCEMOVIMENTO");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdGerenteSupervisor);
            builder.Property(x => x.DataAbertura);
            builder.Property(x => x.HoraAbertura);
            builder.Property(x => x.DataFechamento);
            builder.Property(x => x.HoraFechamento);
            builder.Property(x => x.TotalSuprimento);
            builder.Property(x => x.TotalSangria);
            builder.Property(x => x.TotalNaoFiscal);
            builder.Property(x => x.TotalVenda);
            builder.Property(x => x.TotalDesconto);
            builder.Property(x => x.TotalAcrescimo);
            builder.Property(x => x.TotalFinal);
            builder.Property(x => x.TotalRecebido);
            builder.Property(x => x.TotalTroco);
            builder.Property(x => x.TotalCancelado);
            builder.Property(x => x.StatusMovimento);

            /*

        public Empresa Empresa { get; set; }
        public NfceTurno NfceTurno { get; set; }
        public NfceOperador NfceOperador { get; set; }
        public NfceCaixa NfceCaixa { get; set; }

        public IList<NfceFechamento> ListaNfceFechamento { get; set; }
        public IList<NfceSuprimento> ListaNfceSuprimento { get; set; }
        public IList<NfceSangria> ListaNfceSangria { get; set; }
             
             
             */
        }
    }
}
