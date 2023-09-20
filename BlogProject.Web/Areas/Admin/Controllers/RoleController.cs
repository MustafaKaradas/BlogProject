using BlogProject.Entities;
using BlogProject.Models.VMs.RoleVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BlogProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        //[Route("Rolelist"), Route("Admin/Role/Index")]
        public IActionResult Index()
        {
            List<RoleListVm> roleListVms = _roleManager.Roles.Select(x => new RoleListVm
            {
                Id = x.Id,
                RoleName = x.Name,
            }).ToList();


            return View(roleListVms);
        }


        public IActionResult Create()
        {
            RoleCreateVm roleCreateVm = new RoleCreateVm()
            {
                Id = 1
            };


            return View(roleCreateVm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleCreateVm roleCreateVm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppRole newRole = new AppRole()
            {

                Name = roleCreateVm.RoleName,


            };
            IdentityResult identityResult = await _roleManager.CreateAsync(newRole);
            if (!identityResult.Succeeded)
            {
                return Content("Hata Oluştu");
            };
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> AsignUser(int roleId)
        {
            AppRole role = await _roleManager.FindByIdAsync(roleId.ToString());



            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();



            bool Ismember = await _userManager.IsInRoleAsync(_userManager.Users.First(), role.Name);



            var list = _userManager.Users.ToArray();



            foreach (AppUser user in list)
            {
                Ismember = await _userManager.IsInRoleAsync(user, role.Name);
                if (Ismember)
                {
                    members.Add(user);
                }
                else
                {
                    nonMembers.Add(user);
                }
            }
            RoleAsignUserVm vm = new RoleAsignUserVm()
            {
                RoleId = role.Id,
                RoleName = role.Name,
                Members = members,
                NonMembers = nonMembers
            };



            return View(vm);
        }


        [HttpPost]
        public async Task<IActionResult> AsignUser(RoleAsignUserVm roleAsignUserVM)
        {
            IdentityResult result;



            if (!ModelState.IsValid) { return View(roleAsignUserVM); }
            if (roleAsignUserVM != null)
            {
                if (roleAsignUserVM.AddIns != null)
                {
                    var list = roleAsignUserVM.AddIns.ToArray();
                    foreach (string item in list)
                    {
                        AppUser user = await _userManager.FindByIdAsync(item);
                        if (user == null)
                        {
                            return Content("Lütfen bir kullanıcı seçiniz.");
                        }
                        result = await _userManager.AddToRoleAsync(user, roleAsignUserVM.RoleName);
                        if (!result.Succeeded)
                        {
                            return Content("Kişi eklenemedi.");
                        }
                    }
                }



                if (roleAsignUserVM.Remove != null)
                {
                    var list = roleAsignUserVM.Remove.ToArray();
                    foreach (string item in list)
                    {
                        AppUser user = await _userManager.FindByIdAsync(item);
                        if (user == null)
                        {
                            return Content("Lütfen bir kullanıcı seçiniz.");
                        }
                        result = await _userManager.RemoveFromRoleAsync(user, roleAsignUserVM.RoleName);
                        if (!result.Succeeded)
                        {
                            return Content("Kişi eklenemedi.");
                        }
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
