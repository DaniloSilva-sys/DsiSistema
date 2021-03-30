using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFCe.Api.Domain.Models
{
    public class NfeDetalhe
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public NfeDetalheImpostoIcms NfeDetalheImpostoIcms { get; set; }
        public int IdNfeCabecalho { get; set; }
        public int? NumeroItem { get; set; }
        public string CodigoProduto { get; set; }
        public string Gtin { get; set; }
        public string NomeProduto { get; set; }
        public string Ncm { get; set; }
        public string Nve { get; set; }
        public int? ExTipi { get; set; }
        public int? Cfop { get; set; }
        public string UnidadeComercial { get; set; }
        public decimal? QuantidadeComercial { get; set; }
        public decimal? ValorUnitarioComercial { get; set; }
        public decimal? ValorBrutoProduto { get; set; }
        public string GtinUnidadeTributavel { get; set; }
        public string UnidadeTributavel { get; set; }
        public decimal? QuantidadeTributavel { get; set; }
        public decimal? ValorUnitarioTributavel { get; set; }
        public decimal? ValorFrete { get; set; }
        public decimal? ValorSeguro { get; set; }
        public decimal? ValorDesconto { get; set; }
        public decimal? ValorOutrasDespesas { get; set; }
        public int? EntraTotal { get; set; }
        public decimal? ValorSubtotal { get; set; }
        public decimal? ValorTotal { get; set; }
        public string NumeroPedidoCompra { get; set; }
        public int? ItemPedidoCompra { get; set; }
        public string InformacoesAdicionais { get; set; }
        public string NumeroFci { get; set; }
        public string NumeroRecopi { get; set; }
        public decimal? ValorTotalTributos { get; set; }
        public decimal? PercentualDevolvido { get; set; }
        public decimal? ValorIpiDevolvido { get; set; }
    }
}