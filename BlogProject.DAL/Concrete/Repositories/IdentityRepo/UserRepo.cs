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
    public class UserRepo : IUserRepo
    {
        private readonly UserManager<AppUser> _userManager;

        public UserRepo(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task CreateAsync(AppUser entity)
        {
            
            await _userManager.CreateAsync(entity);
        }

        public async void Delete(AppUser entity)
        {
            await _userManager.DeleteAsync(entity);
        }

        public async Task<List<AppUser>> GetAllAsync()
        {
            return _userManager.Users.ToList();
        }

        public AppUser GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<AppUser> GetByIdAsync(int id)
        {
           return await _userManager.FindByIdAsync(id.ToString());
        }

        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<AppUser, TResult>> select, Expression<Func<AppUser, bool>> where, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>>? orderBy = null, params Expression<Func<AppUser, object>>[] inculudes)
        {
            throw new NotImplementedException();
        }

        public async void Update(AppUser entity)
        {
            await _userManager.UpdateAsync(entity);
        }
    }
}
