namespace NFCe.Api.Domain.Models
{
    public class NfeFormaPagamento
    {
        public int Id { get; set; }
        public int IdNfeCabecalho { get; set; }
        public NfceTipoPagamento NfceTipoPagamento { get; set; }
        public string Forma { get; set; }
        public decimal? Valor { get; set; }
        public string CnpjOperadoraCartao { get; set; }
        public string Bandeira { get; set; }
        public string NumeroAutorizacao { get; set; }
        public string Estorno { get; set; }
    }
}