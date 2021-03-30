namespace NFCe.Api.Domain.Models
{
    public class NfeNumero
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string Serie { get; set; }
        public int? Numero { get; set; }
    }
}