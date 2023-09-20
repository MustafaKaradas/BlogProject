using BlogProject.Core.BaseEntities;
using BlogProject.Core.IBaseRepositories;
using BlogProject.DAL.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Base
{
    public class BaseStandartContextRepo<TEntity, TContext> : IBaseStandartContextRepo<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        private AppDbContext _context;

        protected readonly TContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseStandartContextRepo(TContext context, AppDbContext dbcontext)
        {
            _db = context;
            _dbSet=_db.Set<TEntity>();
            //_context = dbcontext;

            //if (_context == null)
            //{
            //    _context = new AppDbContext();
            //}

        }


        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            _db.SaveChanges();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public void Update(TEntity entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            _db.SaveChanges();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, params Expression<Func<TEntity, object>>[] inculudes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }
            if (inculudes != null)
            {
                query = query.MyIncludes(inculudes);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(select).ToList();
            }
            else
            {
                return query.Select(select).ToList();
            }
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public TEntity GetByCategoryId(int categoryId)
        {
            return _dbSet.Find(categoryId);
        }
    }
}
