using System;
using System.Collections.Generic;

namespace NFCe.Api.Domain.Models
{
    public class NfeCabecalho
    {
        public NfeCabecalho()
        {
            ListaNfeDetalhe = new List<NfeDetalhe>();
            ListaNfeFormaPagamento = new List<NfeFormaPagamento>();
            NfeDestinatario = new NfeDestinatario();
        }

        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdNfceMovimento { get; set; }
        public int? IdVendedor { get; set; }
        public int? UfEmitente { get; set; }
        public string CodigoNumerico { get; set; }
        public string NaturezaOperacao { get; set; }
        public int? IndicadorFormaPagamento { get; set; }
        public string CodigoModelo { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public DateTime? DataHoraEmissao { get; set; }
        public DateTime? DataHoraEntradaSaida { get; set; }
        public int? TipoOperacao { get; set; }
        public int? LocalDestino { get; set; }
        public int? CodigoMunicipio { get; set; }
        public int? FormatoImpressaoDanfe { get; set; }
        public int? TipoEmissao { get; set; }
        public string ChaveAcesso { get; set; }
        public string DigitoChaveAcesso { get; set; }
        public int? Ambiente { get; set; }
        public int? FinalidadeEmissao { get; set; }
        public int? ConsumidorOperacao { get; set; }
        public int? ConsumidorPresenca { get; set; }
        public int? ProcessoEmissao { get; set; }
        public string VersaoProcessoEmissao { get; set; }
        public DateTime? DataEntradaContingencia { get; set; }
        public string JustificativaContingencia { get; set; }
        public decimal? BaseCalculoIcms { get; set; }
        public decimal? ValorIcms { get; set; }
        public decimal? ValorIcmsDesonerado { get; set; }
        public decimal? BaseCalculoIcmsSt { get; set; }
        public decimal? ValorIcmsSt { get; set; }
        public decimal? ValorTotalProdutos { get; set; }
        public decimal? ValorFrete { get; set; }
        public decimal? ValorSeguro { get; set; }
        public decimal? ValorDesconto { get; set; }
        public decimal? ValorImpostoImportacao { get; set; }
        public decimal? ValorIpi { get; set; }
        public decimal? ValorPis { get; set; }
        public decimal? ValorCofins { get; set; }
        public decimal? ValorDespesasAcessorias { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? ValorServicos { get; set; }
        public decimal? BaseCalculoIssqn { get; set; }
        public decimal? ValorIssqn { get; set; }
        public decimal? ValorPisIssqn { get; set; }
        public decimal? ValorCofinsIssqn { get; set; }
        public DateTime DataPrestacaoServico { get; set; }
        public decimal? ValorDeducaoIssqn { get; set; }
        public decimal? OutrasRetencoesIssqn { get; set; }
        public decimal? DescontoIncondicionadoIssqn { get; set; }
        public decimal? DescontoCondicionadoIssqn { get; set; }
        public decimal? TotalRetencaoIssqn { get; set; }
        public int? RegimeEspecialTributacao { get; set; }
        public decimal? ValorRetidoPis { get; set; }
        public decimal? ValorRetidoCofins { get; set; }
        public decimal? ValorRetidoCsll { get; set; }
        public decimal? BaseCalculoIrrf { get; set; }
        public decimal? ValorRetidoIrrf { get; set; }
        public decimal? BaseCalculoPrevidencia { get; set; }
        public decimal? ValorRetidoPrevidencia { get; set; }
        public string ComexUfEmbarque { get; set; }
        public string ComexLocalEmbarque { get; set; }
        public string ComexLocalDespacho { get; set; }
        public string CompraNotaEmpenho { get; set; }
        public string CompraPedido { get; set; }
        public string CompraContrato { get; set; }
        public string InformacoesAddFisco { get; set; }
        public string InformacoesAddContribuinte { get; set; }
        public int? StatusNota { get; set; }
        public decimal? Troco { get; set; }

        public NfeDestinatario NfeDestinatario { get; set; }
        public IList<NfeDetalhe> ListaNfeDetalhe { get; set; }
        public IList<NfeFormaPagamento> ListaNfeFormaPagamento { get; set; }
    }
}
