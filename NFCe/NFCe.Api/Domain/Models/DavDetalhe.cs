using System;

namespace NFCe.Api.Domain.Models
{
    public class DavDetalhe
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int IdDavCabecalho { get; set; }
        public string NumeroDav { get; set; }
        public DateTime? DataEmissao { get; set; }
        public int? Item { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? ValorTotal { get; set; }
        public string Cancelado { get; set; }
        public string MesclaProduto { get; set; }
        public string GtinProduto { get; set; }
        public string NomeProduto { get; set; }
        public string UnidadeProduto { get; set; }
        public string TotalizadorParcial { get; set; }
        public string Logss { get; set; }
    }
}