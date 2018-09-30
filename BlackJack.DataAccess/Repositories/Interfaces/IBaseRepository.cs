using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DataAccess.Repositories.Interfaces
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
