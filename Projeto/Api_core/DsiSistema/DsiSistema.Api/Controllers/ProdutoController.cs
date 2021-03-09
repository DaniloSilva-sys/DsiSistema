using System;
using System.Threading.Tasks;
using DsiSistema.Api.Models;
using DsiSistema.Api.Models.Interfaces.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DsiSistema.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _repository;
        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("ObterProdutoPorCodigoInterno")]
        public async Task<IActionResult> ObterProdutoPorCodigoInterno(Produto item)
        {
            try
            {
                var retorno = await _repository.Obter(x => x.ControleInterno == item.ControleInterno);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

            return null;
        }

        [HttpGet("ObterProdutoPorCodigoBarra")]
        public async Task<IActionResult> ObterProdutoPorCodigoBarra(Produto item)
        {
            try
            {
                var retorno = await _repository.Obter(x => x.CodigoBarra == item.CodigoBarra);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

            return null;
        }

        [HttpGet("Listar")]
        [AllowAnonymous]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var retono = await _repository.Listar();
                return Ok(retono);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

            return null;
        }

        [HttpPost("Adicionar")]
        [AllowAnonymous]
        public IActionResult Adicionar(Produto item)
        {
            try
            {                
                return Ok(_repository.Adicionar(item));                                
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

            return null;
        }

        [HttpPost("Atualizar")]
        public IActionResult Atualizar(Produto item)
        {
            try
            {
                return Ok(_repository.Atualizar(item));                                
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
            return null;            
        }

        [HttpPost("Excluir")]
        public IActionResult Excluir(Produto item)
        {
            try
            {
                return Ok(_repository.Excluir(item));                                
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

            return null;
        }
    }
}