namespace NFCe.Api.Domain.Models
{
    public class TributOperacaoFiscal
    {
        public int Id { get; set; }
        public Empresa Empresa { get; set; }
        public string Descricao { get; set; }
        public string DescricaoNaNf { get; set; }
        public int? Cfop { get; set; }
        public string Observacao { get; set; }
    }
}