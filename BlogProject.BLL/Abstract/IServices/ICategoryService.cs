using BlogProject.Entities;
using BlogProject.Models.VMs.ArticleVM;
using BlogProject.Models.VMs.CategoryVm;
using BlogProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Abstract.IServices
{
    public interface ICategoryService
    {
        ResultService<List<CategoryListVm>> GetAll();

        Category GetById(int id);
    }
}
