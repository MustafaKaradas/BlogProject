using BlogProject.Entities;
using BlogProject.Models.DTOs.ArticleDTO;
using BlogProject.Models.DTOs.UserDTO;
using BlogProject.Models.VMs.ArticleVM;
using BlogProject.Models.VMs.UserVM;
using BlogProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Abstract.IServices
{
    public interface IUserService
    {
        ResultService<UserCreateDto> Create(UserCreateVm createVM);

        void Update(AppUser user);

        void Delete(AppUser user);

        Task<List<AppUser>> GetAll();

        Task<AppUser> GetByIdAsync(int id);

    }
}
