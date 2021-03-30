using System.Collections.Generic;

namespace NFCe.Api.Domain.Models
{
    public class NfceResolucao
    {
        public NfceResolucao()
        {
            ListaNfcePosicaoComponentes = new List<NfcePosicaoComponentes>();
        }
        public int Id { get; set; }
        public string ResolucaoTela { get; set; }
        public int? Largura { get; set; }
        public int? Altura { get; set; }
        public string ImagemTela { get; set; }
        public string ImagemMenu { get; set; }
        public string ImagemSubmenu { get; set; }

        public IList<NfcePosicaoComponentes> ListaNfcePosicaoComponentes { get; set; }
    }
}