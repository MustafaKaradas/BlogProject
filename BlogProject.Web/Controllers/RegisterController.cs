using BlogProject.Entities;
using BlogProject.Models.VMs.RegisterVM;
using MailKit.Net.Smtp;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace BlogProject.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityUserRole> _roleManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> UserRegister()
        {

            

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(RegisterVm registerVm)
        {
            if (ModelState.IsValid) 
            {
                Random random = new Random();
                int code;
                code = random.Next(200000, 2000000);

                AppUser user = new AppUser()
                {
                    Id = registerVm.Id,
                    UserName = registerVm.UserName,
                    FirstName = registerVm.FirstName,
                    LastName = registerVm.LastName,
                    Email = registerVm.Email,
                    Password=registerVm.Password,
                    ConfirmPassword = registerVm.ConfirmPassword,
                    ConfirmCode = code
                    
                    
                };
                var result = await _userManager.CreateAsync(user, registerVm.Password);

                var lastUser = await _userManager.FindByEmailAsync(registerVm.Email);

                var result2 = await _userManager.AddToRoleAsync(lastUser,"User");

                if (result.Succeeded&& result2.Succeeded)
                {
                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("Blog Site Admin", "karadas191919@gmail.com"); // bu sınıfım mailin kimden gideceğini gösterecek.
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", user.Email); // bu doğrulama kodunun hangi maile gideceğini belirttik. user sınıfından gelen mail adresine gidecek.



                    mimeMessage.From.Add(mailboxAddressFrom);
                    mimeMessage.To.Add(mailboxAddressTo);



                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = " Kayıt işlemini gerçekleştirmek için onay kodunuz:" + code; //içeriğin text kısmı 
                    mimeMessage.Body = bodyBuilder.ToMessageBody();



                    mimeMessage.Subject = "Onay Kodu";



                    SmtpClient client = new SmtpClient();
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("karadas191919@gmail.com", "whaocdamrtucubgc");
                    client.Send(mimeMessage);
                    client.Disconnect(true);

                    TempData["Mail"] = registerVm.Email;

                    return RedirectToAction("Index", "ConfirmMail");


                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                return View();
            }
            

            return View();
        }
    }
}
