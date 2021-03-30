using System;
using System.Collections.Generic;

namespace NFCe.Api.Domain.Models
{
    public class NfceMovimento
    {
        public NfceMovimento()
        {
            Empresa = new Empresa();
            NfceTurno = new NfceTurno();
            NfceOperador = new NfceOperador();
            NfceCaixa = new NfceCaixa();
            ListaNfceFechamento = new List<NfceFechamento>();
            ListaNfceSuprimento = new List<NfceSuprimento>();
            ListaNfceSangria = new List<NfceSangria>();
        }

        public int Id { get; set; }
        public int IdGerenteSupervisor { get; set; }
        public DateTime? DataAbertura { get; set; }
        public string HoraAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public string HoraFechamento { get; set; }
        public decimal? TotalSuprimento { get; set; }
        public decimal? TotalSangria { get; set; }
        public decimal? TotalNaoFiscal { get; set; }
        public decimal? TotalVenda { get; set; }
        public decimal? TotalDesconto { get; set; }
        public decimal? TotalAcrescimo { get; set; }
        public decimal? TotalFinal { get; set; }
        public decimal? TotalRecebido { get; set; }
        public decimal? TotalTroco { get; set; }
        public decimal? TotalCancelado { get; set; }
        public string StatusMovimento { get; set; }

        public Empresa Empresa { get; set; }
        public NfceTurno NfceTurno { get; set; }
        public NfceOperador NfceOperador { get; set; }
        public NfceCaixa NfceCaixa { get; set; }

        public IList<NfceFechamento> ListaNfceFechamento { get; set; }
        public IList<NfceSuprimento> ListaNfceSuprimento { get; set; }
        public IList<NfceSangria> ListaNfceSangria { get; set; }
    }
}