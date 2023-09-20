using BlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Models.VMs.ArticleVM
{
    public class ArticleListVm
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? NumberOfLikes { get; set; }
		public string ImagePath { get; set; }
	}
}
