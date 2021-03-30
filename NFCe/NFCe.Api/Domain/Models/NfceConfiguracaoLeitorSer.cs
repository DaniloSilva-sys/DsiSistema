namespace NFCe.Api.Domain.Models
{
    public class NfceConfiguracaoLeitorSer
    {
        public int Id { get; set; }
        public string Usa { get; set; }
        public string Porta { get; set; }
        public int? Baud { get; set; }
        public int? HandShake { get; set; }
        public int? Parity { get; set; }
        public int? StopBits { get; set; }
        public int? DataBits { get; set; }
        public int? Intervalo { get; set; }
        public string UsarFila { get; set; }
        public string HardFlow { get; set; }
        public string SoftFlow { get; set; }
        public string Sufixo { get; set; }
        public string ExcluirSufixo { get; set; }
    }
}