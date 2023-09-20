﻿using BlogProject.Core.IBaseRepositories;
using BlogProject.DAL.Abstract;
using BlogProject.DAL.Base;
using BlogProject.DAL.Concrete.Context;
using BlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete.Repositories.StandartRepo
{
    public class ArticleRepo : BaseStandartContextRepo<Article, AppDbContext>, IArticleRepo
    {
        public ArticleRepo(AppDbContext context, AppDbContext dbcontext) : base(context, dbcontext)
        {
        }
    }
}
