using BlogProject.BLL.Abstract.IServices;
using BlogProject.Entities;
using BlogProject.Models.VMs.ArticleVM;
using BlogProject.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService _articleService;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            var articles = _articleService.GetAll().Data.ToList();
            return View(articles);
        }

        public IActionResult About() 
        {

            return View();
        }

        public IActionResult ArticleDetail(int id)
        {
            //if(id==null) 
            //{
            Article articleDetail = _articleService.GetById(id);

            ArticleDetailVm articleDetailVm = new ArticleDetailVm()
            {
                Id = articleDetail.Id,
                Content = articleDetail.Content,
                CreatedDate = articleDetail.CreatedDate,
                ImagePath = articleDetail.ImagePath,
                Title = articleDetail.Title,
                UserName = articleDetail.UserName

            };


            return View(articleDetailVm);
            //}
            //TempData["Hata"] = "Kayıt Bulunamadı";
            /////////// O ID DE ÜRÜN YOKSA ANA SAYFADA ALERT İÇİNDE KAYIT BULUNAMADI DİYE DÖNDÜRÜR
            //return RedirectToAction("HomePage");


        }

     


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}