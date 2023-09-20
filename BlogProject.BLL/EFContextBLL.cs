using BlogProject.BLL.Abstract.IServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.DAL;
using BlogProject.DAL.Concrete;
using AutoMapper;
using BlogProject.BLL.Concrete.Services;
using BlogProject.BLL.Concrete.Mapper;

namespace BlogProject.BLL
{
    public static class EFContextBLL
    {
        
        public static IServiceCollection AddScopedBll(this IServiceCollection services)
        {
            services.AddScopedDal()
                .AddScoped<IUserService, UserService>()
               .AddScoped<IRoleService, RoleService>()
               .AddScoped<ICategoryService, CategoryService>()
               .AddScoped<IArticleService, ArticleService>();

               


            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Mapping());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);





            return services;
        }

    }
}
