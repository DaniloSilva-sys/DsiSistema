using DsiSistema.Api.Models;
using DsiSistema.Api.Models.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DsiSistema.Api.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DsiContext _context;
        public ProdutoRepository(DsiContext context)
        {
            _context = context;
        }

        public async Task Adicionar(Produto item)
        {
            _context.Produto.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Produto item)
        {
            _context.Produto.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(Produto item)
        {
            _context.Produto.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Produto>> Listar()
        {
            return await _context.Produto.ToListAsync();
        }

        public async Task<Produto> Obter(Expression<Func<Produto, bool>> where)
        {
            return await _context.Produto.FirstOrDefaultAsync(where);
        }
    }
}