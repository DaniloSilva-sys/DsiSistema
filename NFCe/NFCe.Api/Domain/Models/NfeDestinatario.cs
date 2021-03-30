namespace NFCe.Api.Domain.Models
{
    public class NfeDestinatario
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string EstrangeiroIdentificacao { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int? CodigoMunicipio { get; set; }
        public string NomeMunicipio { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public int? CodigoPais { get; set; }
        public string NomePais { get; set; }
        public string Telefone { get; set; }
        public int? IndicadorIe { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public int? Suframa { get; set; }
        public string Email { get; set; }
    }
}