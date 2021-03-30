using System;

namespace NFCe.Api.Domain.Models
{
    public class NfceCaixa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}