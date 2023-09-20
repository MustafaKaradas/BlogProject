using BlogProject.Entities;
using BlogProject.Models.VMs.RegisterVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Web.Controllers
{
    public class ConfirmMailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public ConfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = TempData["Mail"];
            ViewBag.v = value;
            

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterConfirmMailVm registerConfirmMailVm)
        {
            
            var user = await _userManager.FindByEmailAsync(registerConfirmMailVm.Email);
            if(user.ConfirmCode==registerConfirmMailVm.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","Login");
            }

            return View();
        }
    }
}
