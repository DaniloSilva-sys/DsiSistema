using System;
using System.Collections.Generic;

namespace NFCe.Api.Domain.Models
{
    public class FinLancamentoReceber
    {
        public FinLancamentoReceber() 
        {
            ListaFinParcelaReceber = new List<FinParcelaReceber>();
        }

        public int Id { get; set; }
        public int IdFinDocumentoOrigem { get; set; }
        public int IdCliente { get; set; }
        public int? QuantidadeParcela { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? ValorAReceber { get; set; }
        public DateTime? DataLancamento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime? PrimeiroVencimento { get; set; }
        public decimal? TaxaComissao { get; set; }
        public decimal? ValorComissao { get; set; }
        public int? IntervaloEntreParcelas { get; set; }
        public string CodigoModuloLcto { get; set; }
        public IList<FinParcelaReceber> ListaFinParcelaReceber { get; set; }
    }
}