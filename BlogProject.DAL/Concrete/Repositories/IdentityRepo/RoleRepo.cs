using BlogProject.DAL.Abstract;
using BlogProject.DAL.Base;
using BlogProject.DAL.Concrete.Context;
using BlogProject.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete.Repositories.IdentityRepo
{
    public class RoleRepo : IRoleRepo
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleRepo(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task CreateAsync(AppRole entity)
        {
            await _roleManager.CreateAsync(entity);
        }

        public async void Delete(AppRole entity)
        {
            await _roleManager.DeleteAsync(entity);
        }

        public async Task<List<AppRole>> GetAllAsync()
        {
            return  _roleManager.Roles.ToList();
        }

        public AppRole GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public AppRole GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AppRole> GetByIdAsync(int id)
        {
            return _roleManager.FindByIdAsync(id.ToString());
        }

        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<AppRole, TResult>> select, Expression<Func<AppRole, bool>> where, Func<IQueryable<AppRole>, IOrderedQueryable<AppRole>>? orderBy = null, params Expression<Func<AppRole, object>>[] inculudes)
        {
            throw new NotImplementedException();
        }

        public async void Update(AppRole entity)
        {
            await _roleManager.UpdateAsync(entity);
        }
    }
}
