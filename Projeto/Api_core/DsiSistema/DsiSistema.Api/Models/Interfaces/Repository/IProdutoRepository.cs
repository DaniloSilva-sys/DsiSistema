using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DsiSistema.Api.Models.Interfaces.Repository
{
    public interface IProdutoRepository
    {
        Task<Produto> Obter(Expression<Func<Produto, bool>> where);
        Task<ICollection<Produto>> Listar();
        Task Atualizar(Produto item);
        Task Adicionar(Produto item);
        Task Excluir(Produto item);
    }
}
