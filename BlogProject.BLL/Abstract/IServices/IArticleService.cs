using BlogProject.Entities;
using BlogProject.Models.DTOs.ArticleDTO;
using BlogProject.Models.VMs.ArticleVM;
using BlogProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Abstract.IServices
{
    public interface IArticleService
    {
        ResultService<ArticleCreateDto> Create(ArticleCreateVm createVM);

        void Update(Article article);

        void Delete(Article article);

        ResultService<List<ArticleListVm>> GetAll();

        Article GetById(int id);

        ResultService<List<ArticleListVm>> GetByCategoryId(int categoryId);
    }
}
