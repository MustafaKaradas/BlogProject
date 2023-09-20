using AutoMapper;
using BlogProject.BLL.Abstract.IServices;
using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete.Repositories.StandartRepo;
using BlogProject.Entities;
using BlogProject.Models.VMs.ArticleVM;
using BlogProject.Models.VMs.CategoryVm;
using BlogProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Concrete.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepo categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }
        public ResultService<List<CategoryListVm>> GetAll()
        {
            ResultService<List<CategoryListVm>> result = new ResultService<List<CategoryListVm>>();


            var categories = _categoryRepo.GetFilteredList(select: x => new CategoryListVm
            {
                Id= x.Id,
                CategoryName=x.CategoryName,
                ImagePath=x.ImagePath,



            }, where: x => x.CategoryName != null, inculudes: x => x.Articles);

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

        public Category GetById(int id)
        {
            return _categoryRepo.GetById(id);
        }
    }
}
