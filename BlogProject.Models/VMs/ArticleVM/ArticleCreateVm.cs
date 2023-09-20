using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Models.VMs.ArticleVM
{
    public class ArticleCreateVm
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }
        public IFormFile File { get; set; }

        public string ImagePath { get; set; }
        public string UserName { get; set; }
    }
}
