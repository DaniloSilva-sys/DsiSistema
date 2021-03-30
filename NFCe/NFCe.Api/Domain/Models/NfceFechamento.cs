namespace NFCe.Api.Domain.Models
{
    public class NfceFechamento
    {
        public int Id { get; set; }
        public int IdNfceMovimento { get; set; }
        public string TipoPagamento { get; set; }
        public decimal? Valor { get; set; }
    }
}