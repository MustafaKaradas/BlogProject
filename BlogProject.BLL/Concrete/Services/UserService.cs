using AutoMapper;
using BlogProject.BLL.Abstract.IServices;
using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete.Repositories.StandartRepo;
using BlogProject.Entities;
using BlogProject.Models.DTOs.ArticleDTO;
using BlogProject.Models.DTOs.UserDTO;
using BlogProject.Models.VMs.UserVM;
using BlogProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Concrete.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;
        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public ResultService<UserCreateDto> Create(UserCreateVm createVM)
        {
            ResultService<UserCreateDto> result = new ResultService<UserCreateDto>();

            UserCreateDto createDto = _mapper.Map<UserCreateDto>(createVM);
            AppUser newUser = _mapper.Map<AppUser>(createDto);
            var addedUser = _userRepo.CreateAsync(newUser);
            if (addedUser != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public void Delete(AppUser user)
        {
            _userRepo.Delete(user);
        }

        public Task<List<AppUser>> GetAll()
        {
            return _userRepo.GetAllAsync();
        }

        public Task<AppUser> GetByIdAsync(int id)
        {
            return _userRepo.GetByIdAsync(id);
        }

        public void Update(AppUser user)
        {
            _userRepo.Update(user);
        }
    }
}
