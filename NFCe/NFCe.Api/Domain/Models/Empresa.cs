using System;
using System.Collections.Generic;

namespace NFCe.Api.Domain.Models
{
    public class Empresa
    {
        public Empresa()
        {
            ListaEndereco = new List<EmpresaEndereco>();
            Endereco = new EmpresaEndereco();
    }
        public int Id { get; set; }
        public Empresa DadosEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoEstadualSt { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoJuntaComercial { get; set; }
        public DateTime? DataInscJuntaComercial { get; set; }
        public string Tipo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataInicioAtividades { get; set; }
        public string Suframa { get; set; }
        public string Email { get; set; }
        public string ImagemLogotipo { get; set; }
        public string Crt { get; set; }
        public string TipoRegime { get; set; }
        public decimal? AliquotaPis { get; set; }
        public string Contato { get; set; }
        public decimal? AliquotaCofins { get; set; }
        public int? CodigoIbgeCidade { get; set; }
        public int? CodigoIbgeUf { get; set; }
        public int? CodigoTerceiros { get; set; }
        public int? CodigoGps { get; set; }
        public decimal? AliquotaSat { get; set; }
        public string Cei { get; set; }
        public string CodigoCnaePrincipal { get; set; }
        public string TipoControleEstoque { get; set; }

        public IList<EmpresaEndereco> ListaEndereco { get; set; }
        public EmpresaEndereco Endereco { get; set; }
    }
}