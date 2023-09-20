using BlogProject.Entities;
using BlogProject.Models.DTOs.RoleDTO;
using BlogProject.Models.DTOs.UserDTO;
using BlogProject.Models.VMs.RoleVM;
using BlogProject.Models.VMs.UserVM;
using BlogProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Abstract.IServices
{
    public interface IRoleService
    {
        ResultService<RoleCreateDto> Create(RoleCreateVm createVM);
        
        void Delete(AppRole role);

        Task<List<AppRole>> GetAll();

        Task<AppRole> GetByIdAsync(int id);
    }
}
