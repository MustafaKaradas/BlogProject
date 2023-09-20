using BlogProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Models.VMs.RoleVM
{
    public class RoleAsignUserVm
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }


        public ICollection<AppUser> Members { get; set; }


        public ICollection<AppUser> NonMembers { get; set; }

        public string[]? AddIns { get; set; }

        public string[]? Remove { get; set; }

        public RoleAsignUserVm()
        {
            Members = new HashSet<AppUser>();
            NonMembers = new HashSet<AppUser>();
        }
    }
}
