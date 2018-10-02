using BlackJack.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJack.DataAccess.Repositories
{
    public interface IBaseRepository<TEntity>
    {
        IEnumerable<TEntity> All();
        TEntity Get(Guid id);
        TEntity Add(TEntity entity);
        void Delete(TEntity entity);
        Task SaveChangesAsync();
    }
}
