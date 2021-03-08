using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DsiSistema.Api.Models.Interfaces.Repository.Base
{
    public interface IRepositoryBase<TEntity, TId> where TEntity : class where TId : struct
    {
        IQueryable<TEntity> ListarPor(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> ListarEOrdenarPor<TKey>(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include);
        TEntity ObterPor(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] include);
        bool Existe(Func<TEntity, bool> where);
        IQueryable<TEntity> Listar(params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> ListarEOrdenarPor<TKey>(Expression<Func<TEntity, TKey>> ordem, bool ascedente = true, params Expression<Func<TEntity, object>>[] include);
        TEntity ObterPorId(TId id, params Expression<Func<TEntity, object>>[] include);
        TEntity Adicionar(TEntity entity);
        TEntity Editar(TEntity entity);
        TEntity Remover(TEntity entity);
        TEntity Remover(IEnumerable<TEntity> entity);

    }
}