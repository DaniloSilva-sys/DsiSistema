using System;

namespace NFCe.Api.Domain.Models
{
    public class FinParcelaReceber
    {
        public int Id { get; set; }
        public int IdContaCaixa { get; set; }
        public int IdFinLancamentoReceber { get; set; }
        public int IdFinStatusParcela { get; set; }
        public int? NumeroParcela { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DescontoAte { get; set; }
        public decimal? Valor { get; set; }
        public decimal? TaxaJuro { get; set; }
        public decimal? TaxaMulta { get; set; }
        public decimal? TaxaDesconto { get; set; }
        public decimal? ValorJuro { get; set; }
        public decimal? ValorMulta { get; set; }
        public decimal? ValorDesconto { get; set; }
        public string EmitiuBoleto { get; set; }
        public string BoletoNossoNumero { get; set; }
    }
}