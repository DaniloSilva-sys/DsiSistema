using System;

namespace NFCe.Api.Domain.Models
{
    public class NfceSuprimento
    {
        public int Id { get; set; }
        public int IdNfceMovimento { get; set; }
        public DateTime? DataSuprimento { get; set; }
        public decimal? Valor { get; set; }
        public string Observacao { get; set; }
    }
}