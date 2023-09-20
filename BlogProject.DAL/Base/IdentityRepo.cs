using BlogProject.Core.BaseEntities;
using BlogProject.Core.IBaseRepositories;
using BlogProject.DAL.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Base
{
    public class IdentityRepo<TEntity, TContext> : IIdentityRepo<TEntity>
        where TEntity : class
        where TContext : AppIdentityContext
    {
        

        public Task CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public TEntity GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, params Expression<Func<TEntity, object>>[] inculudes)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<TEntity>.Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<TEntity>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
