namespace NFCe.Api.Domain.Models
{
    public class UnidadeProduto
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public string PodeFracionar { get; set; }
    }
}