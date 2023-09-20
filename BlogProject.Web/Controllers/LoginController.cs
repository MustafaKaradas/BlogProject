using BlogProject.Entities;
using BlogProject.Models.VMs.LoginVM;
using BlogProject.Models.VMs.RegisterVM;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityUserRole> _roleManager;


        public LoginController(SignInManager<AppUser> signInManager,
        UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager; 

        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(LoginVm loginVm)
        {

            var result = await _signInManager.PasswordSignInAsync(loginVm.UserName,loginVm.Password,false,true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginVm.UserName);

                var userRole = await _userManager.GetRolesAsync(user);
                
                if(user.EmailConfirmed == true) 
                {
                    
                    return RedirectToAction("Index", "StandartUser", new { area = "StandartUser" });
                }
                

            }
            return View();
        }
    }
}
