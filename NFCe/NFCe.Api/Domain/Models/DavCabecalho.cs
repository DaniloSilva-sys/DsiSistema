using System;
using System.Collections.Generic;

namespace NFCe.Api.Domain.Models
{
    public class DavCabecalho
    {
        public DavCabecalho()
        {
            ListaDavDetalhe = new List<DavDetalhe>();
        }

        public int Id { get; set; }
        public Empresa Empresa { get; set; }
        public string NumeroDav { get; set; }
        public string NumeroEcf { get; set; }
        public int? Ccf { get; set; }
        public int? Coo { get; set; }
        public string NomeDestinatario { get; set; }
        public string CpfCnpjDestinatario { get; set; }
        public DateTime? DataEmissao { get; set; }
        public string HoraEmissao { get; set; }
        public string Situacao { get; set; }
        public decimal? TaxaAcrescimo { get; set; }
        public decimal? Acrescimo { get; set; }
        public decimal? TaxaDesconto { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Valor { get; set; }
        public string Impresso { get; set; }
        public string Logss { get; set; }

        public IList<DavDetalhe> ListaDavDetalhe { get; set; }
    }
}
