namespace NFCe.Api.Domain.Models
{
    public class NfceOperador
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string NivelAutorizacao { get; set; }
    }
}