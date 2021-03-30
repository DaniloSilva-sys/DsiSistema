namespace NFCe.Api.Domain.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public int IdColaborador { get; set; }
        public decimal? Comissao { get; set; }
        public decimal? MetaVendas { get; set; }
    }
}