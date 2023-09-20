using AutoMapper;
using BlogProject.BLL.Abstract.IServices;
using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete.Repositories.StandartRepo;
using BlogProject.Entities;
using BlogProject.Models.DTOs.ArticleDTO;
using BlogProject.Models.VMs.ArticleVM;
using BlogProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Concrete.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepo _articleRepo;
        private readonly IMapper _mapper;

        public ArticleService(IArticleRepo articleRepo, IMapper mapper)
        {
            _articleRepo = articleRepo; 
            _mapper = mapper;
        }
        public  ResultService<ArticleCreateDto> Create(ArticleCreateVm createVM)
        {
            ResultService<ArticleCreateDto> result = new ResultService<ArticleCreateDto>();

            ArticleCreateDto createDto = _mapper.Map<ArticleCreateDto>(createVM);
            Article newArticle = _mapper.Map<Article>(createDto);
            var addedArticle =  _articleRepo.CreateAsync(newArticle);

            if (addedArticle != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public void Delete(Article article)
        {
            _articleRepo.Delete(article);
        }

        public  ResultService <List<ArticleListVm>> GetAll()
        {
            ResultService<List<ArticleListVm>> result = new ResultService<List<ArticleListVm>>();


            var categories = _articleRepo.GetFilteredList(select: x => new ArticleListVm
            {
                Id= x.Id,
                Content= x.Content,
                Title= x.Title,
                UserId=x.UserId,
                ImagePath=x.ImagePath,
                CreatedDate=x.CreatedDate,
                UserName=x.UserName,
                Category=x.Category,
                CategoryId=x.CategoryId,
                
                
                
            }, where: x => x.Title != null, inculudes: x => x.Category);

            if (categories != null)
            {
                result.Data = categories.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;

        }

        public ResultService<List<ArticleListVm>> GetByCategoryId(int categoryId)
        {
            ResultService<List<ArticleListVm>> result = new ResultService<List<ArticleListVm>>();


            var categories = _articleRepo.GetFilteredList(select: x => new ArticleListVm
            {
                Id = x.Id,
                Content = x.Content,
                Title = x.Title,
                UserId = x.UserId,
                ImagePath = x.ImagePath,
                CreatedDate = x.CreatedDate,
                UserName = x.UserName,
                Category = x.Category,
                CategoryId = x.CategoryId,



            }, where: x => x.CategoryId ==categoryId, inculudes: x => x.Category);

            if (categories != null)
            {
                result.Data = categories.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;
        }

        public Article GetById(int id)
        {
            return  _articleRepo.GetById(id);

        }

        public void Update(Article article)
        {
            _articleRepo.Update(article);
        }
    }
}
