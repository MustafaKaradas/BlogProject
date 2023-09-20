using BlogProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete.Context.EntityConfiguration
{
    public class AppRoleTypeConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.HasData(
                new AppRole { Id = 1, Name = "Admin" ,NormalizedName="ADMIN"},
                new AppRole { Id = 2, Name = "User" ,NormalizedName="USER"}

                );
        }
    }
}
