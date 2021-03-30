using System;

namespace NFCe.Api.Domain.Models
{
    public class ViewNfceCliente
    {
        public int Id { get; set; }
        public int? IdOperacaoFiscal { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string OrgaoRg { get; set; }
        public DateTime? DataEmissaoRg { get; set; }
        public string Sexo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int IdPessoa { get; set; }
        public int IdAtividadeForCli { get; set; }
        public int IdSituacaoForCli { get; set; }
        public DateTime? Desde { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public int? MunicipioIbge { get; set; }
        public string Uf { get; set; }
        public string Fone { get; set; }
    }
}