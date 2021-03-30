namespace NFCe.Api.Domain.Models
{
    public class EmpresaEndereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Fone { get; set; }
        public int? MunicipioIbge { get; set; }
        public string Uf { get; set; }
        public string Principal { get; set; }
        public string Entrega { get; set; }
        public string Cobranca { get; set; }
        public string Correspondencia { get; set; }
    }
}