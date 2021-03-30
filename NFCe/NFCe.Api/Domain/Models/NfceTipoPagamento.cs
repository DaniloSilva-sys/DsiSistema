namespace NFCe.Api.Domain.Models
{
    public class NfceTipoPagamento
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string PermiteTroco { get; set; }
        public string GeraParcelas { get; set; }
    }
}