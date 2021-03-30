namespace NFCe.Api.Domain.Models
{
    public class NfeDetalheImpostoIcms
    {
        public int Id { get; set; }
        public int IdNfeDetalhe { get; set; }
        public int? OrigemMercadoria { get; set; }
        public string CstIcms { get; set; }
        public string Csosn { get; set; }
        public int? ModalidadeBcIcms { get; set; }
        public decimal? TaxaReducaoBcIcms { get; set; }
        public decimal? BaseCalculoIcms { get; set; }
        public decimal? AliquotaIcms { get; set; }
        public decimal? ValorIcms { get; set; }
        public decimal? ValorIcmsOperacao { get; set; }
        public decimal? PercentualDiferimento { get; set; }
        public decimal? ValorIcmsDiferido { get; set; }
        public int? MotivoDesoneracaoIcms { get; set; }
        public decimal? ValorIcmsDesonerado { get; set; }
        public int? ModalidadeBcIcmsSt { get; set; }
        public decimal? PercentualMvaIcmsSt { get; set; }
        public decimal? PercentualReducaoBcIcmsSt { get; set; }
        public decimal? ValorBaseCalculoIcmsSt { get; set; }
        public decimal? AliquotaIcmsSt { get; set; }
        public decimal? ValorIcmsSt { get; set; }
        public decimal? ValorBcIcmsStRetido { get; set; }
        public decimal? ValorIcmsStRetido { get; set; }
        public decimal? ValorBcIcmsStDestino { get; set; }
        public decimal? ValorIcmsStDestino { get; set; }
        public decimal? AliquotaCreditoIcmsSn { get; set; }
        public decimal? ValorCreditoIcmsSn { get; set; }
        public decimal? PercentualBcOperacaoPropria { get; set; }
        public string UfSt { get; set; }
    }
}