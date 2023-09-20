using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Models.VMs.CategoryVm
{
    public class CategoryListVm
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public string ImagePath { get; set; }
    }
}
