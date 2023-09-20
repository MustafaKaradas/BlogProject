using AutoMapper;
using BlogProject.Entities;
using BlogProject.Models.DTOs.ArticleDTO;
using BlogProject.Models.DTOs.RoleDTO;
using BlogProject.Models.DTOs.UserDTO;
using BlogProject.Models.VMs.ArticleVM;
using BlogProject.Models.VMs.RoleVM;
using BlogProject.Models.VMs.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Concrete.Mapper
{
    public class Mapping:Profile
    {
        public Mapping() 
        {
            CreateMap<Article, ArticleCreateDto>().ReverseMap();
            CreateMap<Article, ArticleUpdateDto>().ReverseMap();
            CreateMap<Article, ArticleListDto>().ReverseMap();
            CreateMap<ArticleCreateDto, ArticleCreateVm>().ReverseMap();
            CreateMap<ArticleListDto, ArticleListVm>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleUpdateVm>().ReverseMap();

            CreateMap<AppUser, UserCreateDto>().ReverseMap();
            CreateMap<AppUser, UserUpdateDto>().ReverseMap();
            CreateMap<AppUser, UserListDto>().ReverseMap();
            CreateMap<UserCreateDto, UserCreateVm>().ReverseMap();
            CreateMap<UserUpdateDto, UserUpdateVm>().ReverseMap();
            CreateMap<UserListDto, UserListVm>().ReverseMap();

            CreateMap<AppRole, RoleCreateDto>().ReverseMap();
            CreateMap<AppRole, RoleListDto>().ReverseMap();
            CreateMap<RoleCreateDto, RoleCreateVm>().ReverseMap();
            CreateMap<RoleListDto, RoleListVm>().ReverseMap();




        }
    }
}
