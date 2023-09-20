using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete.Context;
using BlogProject.DAL.Concrete.Repositories.IdentityRepo;
using BlogProject.DAL.Concrete.Repositories.StandartRepo;
using BlogProject.Entities;
using BlogProject.Models.CustomIdentityValidator;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete
{
    public static class EFContextDAL
    {
        public static IServiceCollection AddScopedDal(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                string standartCon = "Server=DESKTOP-BL7JRR4\\SQL2022; Database=BlogDatabase; Trusted_Connection=True; MultipleActiveResultSets=true;";
                options.UseSqlServer(standartCon);
            });

            services.AddDbContext<AppIdentityContext>(options =>
            {
                string identityCon = "Server=DESKTOP-BL7JRR4\\SQL2022; Database=BlogIdentityDatabase; Trusted_Connection=True; MultipleActiveResultSets=true;";
                options.UseSqlServer(identityCon);

            })
            .AddScoped<IArticleRepo, ArticleRepo>()
            .AddScoped<ICategoryRepo, CategoryRepo>()
            .AddScoped<IRoleRepo, RoleRepo>()
            .AddScoped<IUserRepo, UserRepo>();



            services.AddIdentityCore<AppUser>().AddRoles<AppRole>().AddEntityFrameworkStores<AppIdentityContext>().AddErrorDescriber<CustomIdentityValidator>();



            services.AddHttpContextAccessor();
            services.TryAddScoped<SignInManager<AppUser>>();




            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = new PathString("/Admin/Auth/Login");
                config.LogoutPath = new PathString("/Admin/Auth/Logout");
                config.Cookie = new CookieBuilder
                {
                    Name = "BlogWebSite",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest //bu kısım önemli. Çünkü burda htp ve https yani ssl sertifikası olan sayfalarda da , mesela https sayfaalrının yanında kilit işareti görebilirsiniz. Bu sitenin güvenli  olduğu anlamına geliyor. Bunu seçerseniz hem http hem de https tarafından istek alabilirsiniz fakat canlıya çıkacağınız zaman always olanını yapmamız daha doğru olurmuş. Biz test yaptığımız için sürekli o yüzden SameAsRequest yaptık.
                };
                config.SlidingExpiration = true;
                config.ExpireTimeSpan = TimeSpan.FromDays(7); // Bu cookienin sistemde ne kadar tutulacağını söylüyor. Diyelim ki bir login yaptım orda işlemler yapıyorum. Siteye giriş yaptıktan sonra oturumum yedi gün boyunca açık kalacak gibi.
                config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); //Yetkisiz bir giriş olduğunda bu sayfamız çalışacak bu actiona atmış olacak yani orda sizin bu sayfaya izniniz yok tarzında bi şey çıkarabiliriz.



            });

            return services;
        }


    }
}
