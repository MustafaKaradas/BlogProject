using AutoMapper;
using BlogProject.BLL.Abstract.IServices;
using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete.Repositories.IdentityRepo;
using BlogProject.Entities;
using BlogProject.Models.DTOs.RoleDTO;
using BlogProject.Models.DTOs.UserDTO;
using BlogProject.Models.VMs.RoleVM;
using BlogProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Concrete.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepo _roleRepo;
        private readonly IMapper _mapper;
        public RoleService(IRoleRepo roleRepo, IMapper mapper)
        {
            _roleRepo = roleRepo;
            _mapper = mapper;
        }
        public ResultService<RoleCreateDto> Create(RoleCreateVm createVM)
        {
            ResultService<RoleCreateDto> result = new ResultService<RoleCreateDto>();

            RoleCreateDto createDto = _mapper.Map<RoleCreateDto>(createVM);
            AppRole newRole = _mapper.Map<AppRole>(createDto);
            var addedRole = _roleRepo.CreateAsync(newRole);
            if (addedRole != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public void Delete(AppRole role)
        {
            _roleRepo.Delete(role);
        }

        public Task<List<AppRole>> GetAll()
        {
            return _roleRepo.GetAllAsync();
        }

        public Task<AppRole> GetByIdAsync(int id)
        {
            return _roleRepo.GetByIdAsync(id);
        }
    }
}
