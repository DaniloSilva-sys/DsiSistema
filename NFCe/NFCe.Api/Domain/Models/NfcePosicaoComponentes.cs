namespace NFCe.Api.Domain.Models
{
    public class NfcePosicaoComponentes
    {
        public int Id { get; set; }
        public int IdNfceResolucao { get; set; }
        public string Nome { get; set; }
        public int? Altura { get; set; }
        public int? Largura { get; set; }
        public int? Topo { get; set; }
        public int? Esquerda { get; set; }
        public int? TamanhoFonte { get; set; }
        public string Texto { get; set; }
    }
}