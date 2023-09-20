using BlogProject.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entities
{
    public  class Article:BaseEntity
    {
        public string  Title { get; set; }

        public string  Content { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public  int? NumberOfLikes { get; set; }
        public string ImagePath { get; set; }
        public string UserName { get; set; }


        //public Image Image { get; set; }

        public int UserId { get; set; }










    }
}
