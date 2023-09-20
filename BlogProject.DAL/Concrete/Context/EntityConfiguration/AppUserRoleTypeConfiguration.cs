using BlogProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete.Context.EntityConfiguration
{
    public class AppUserRoleTypeConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(new AppUserRole()
            {
                UserId = 1,
                RoleId = 1,
            },
            new IdentityUserRole<int>()
            {
                UserId = 2,
                RoleId = 2,
            }
            );
        }
    }
}
