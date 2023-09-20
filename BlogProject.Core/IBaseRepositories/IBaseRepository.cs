using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.IBaseRepositories
{
    public interface  IBaseRepository<TEntity> where TEntity : class
    {
        Task CreateAsync(TEntity entity);
        Task <TEntity> GetByIdAsync(int id);

        TEntity GetById(int id);
        TEntity GetByCategoryId(int categoryId);
        Task<List<TEntity>> GetAllAsync();
        void Update(TEntity entity);
        void Delete(TEntity entity);

        ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select,
                                                       Expression<Func<TEntity, bool>> where,
                                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                      params Expression<Func<TEntity, object>>[] inculudes);

    }
}
