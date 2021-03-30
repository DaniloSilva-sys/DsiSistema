namespace NFCe.Api.Domain.Models
{
    public class NfceConfiguracaoBalanca
    {
        public int Id { get; set; }
        public int? Modelo { get; set; }
        public string Identificador { get; set; }
        public int? HandShake { get; set; }
        public int? Parity { get; set; }
        public int? StopBits { get; set; }
        public int? DataBits { get; set; }
        public int? BaudRate { get; set; }
        public string Porta { get; set; }
        public int? Timeout { get; set; }
        public string TipoConfiguracao { get; set; }
    }
}