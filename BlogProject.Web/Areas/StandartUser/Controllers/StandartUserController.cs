using BlogProject.BLL.Abstract.IServices;
using BlogProject.Entities;
using BlogProject.Models.VMs.ArticleVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BlogProject.Web.Areas.StandartUser.Controllers
{
    [Area("StandartUser")]
    public class StandartUserController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _webHost;

        public StandartUserController(IArticleService articleService, ICategoryService categoryService, IWebHostEnvironment webHost)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _webHost = webHost;

        }
        //[Authorize(Roles = "User")]
        public IActionResult Index()
        {
            var articles = _articleService.GetAll().Data.ToList();
            
            return View(articles);
        }

        public IActionResult Categories()
        {
            var categories = _categoryService.GetAll().Data.ToList();
            return View(categories);
        }
        public IActionResult CategoriesDetail(int categoryId)
        {
            var articles = _articleService.GetByCategoryId(categoryId).Data.ToList();

            return View(articles);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ArticleDetail(int id)
        {
            
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
         


        }
        [HttpGet]
        public IActionResult WriteArticle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriteArticle(ArticleCreateVm articleCreateVm)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(articleCreateVm);
            //}
            //try
            //{

            //    if (articleCreateVm == null)
            //    {
            //        throw new Exception("Boş Nesne");
            //    }


            //    string imgPath = ImageCreate(articleCreateVm.File);


            //    Article article = new Article
            //    {
            //        Title = articleCreateVm.Title,
            //        ImagePath=imgPath,
            //        Content = articleCreateVm.Content,
            //        CategoryId=articleCreateVm.CategoryId,
            //        UserName=articleCreateVm.UserName
            //    };

            //    _articleService.Create(article)

            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}

            return View();
        }

        private string ImageCreate(IFormFile imgFile)
        {
            var saveFolder = Path.Combine(_webHost.WebRootPath, "Images");

            if (!Directory.Exists(saveFolder))
            {
                Directory.CreateDirectory(saveFolder);
            }

            string saveimg = Path.Combine(saveFolder, imgFile.FileName);

            if (!System.IO.File.Exists(saveimg))
            {
                using (var uploading = new FileStream(saveimg, FileMode.Create))
                {
                    imgFile.CopyToAsync(uploading);
                }
            }

            return $@"/Images/{imgFile.FileName}";
        }
    }
}
