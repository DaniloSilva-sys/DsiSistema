namespace NFCe.Api.Domain.Models
{
    public class NfceConfiguracao
    {
        public NfceConfiguracao()
        {
            NfceConfiguracaoBalanca = new NfceConfiguracaoBalanca();
            NfceConfiguracaoLeitorSer = new NfceConfiguracaoLeitorSer();
            NfceResolucao = new NfceResolucao();
            NfceCaixa = new NfceCaixa();
        }
        public int Id { get; set; }
        public string MensagemCupom { get; set; }
        public string TituloTelaCaixa { get; set; }
        public string CaminhoImagensProdutos { get; set; }
        public string CaminhoImagensMarketing { get; set; }
        public string CaminhoImagensLayout { get; set; }
        public string CorJanelasInternas { get; set; }
        public string MarketingAtivo { get; set; }
        public int? Cfop { get; set; }
        public int? DecimaisQuantidade { get; set; }
        public int? DecimaisValor { get; set; }
        public int? QuantidadeMaximaParcela { get; set; }
        public string ImprimeParcela { get; set; }

        public NfceResolucao NfceResolucao { get; set; }
        public NfceCaixa NfceCaixa { get; set; }
        public Empresa Empresa { get; set; }
        public NfceConfiguracaoBalanca NfceConfiguracaoBalanca { get; set; }
        public NfceConfiguracaoLeitorSer NfceConfiguracaoLeitorSer { get; set; }
    }
}