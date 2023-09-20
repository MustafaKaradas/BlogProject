using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entities
{
    public class AppUser : IdentityUser< int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string  Password { get; set; }
        public string  ConfirmPassword { get; set; }


        public int? ConfirmCode { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public AppUser()
        {
            Articles = new HashSet<Article>();
        }
    }
}
