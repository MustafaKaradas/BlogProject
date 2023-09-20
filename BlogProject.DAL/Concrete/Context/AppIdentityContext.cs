using BlogProject.DAL.Concrete.Context.EntityConfiguration;
using BlogProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete.Context
{
    public class AppIdentityContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AppIdentityContext(DbContextOptions<AppIdentityContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserTypeConfiguration());
            builder.ApplyConfiguration(new AppRoleTypeConfiguration());
            builder.ApplyConfiguration(new AppUserRoleTypeConfiguration());

            base.OnModelCreating(builder);
        }

        public virtual DbSet<AppUser> Users { get; set; }
        public virtual DbSet<AppRole> Roles { get; set; }
        public virtual DbSet<AppUserRole> UserRoles { get; set; }
        

    }
}
