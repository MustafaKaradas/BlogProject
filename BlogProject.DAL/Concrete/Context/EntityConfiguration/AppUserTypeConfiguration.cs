using BlogProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete.Context.EntityConfiguration
{
    public class AppUserTypeConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.HasData(
                new AppUser { Id = 1, FirstName = "Mustafa", LastName = "Karadaş", Password = "Karadas19.", UserName = "mustafa19", NormalizedUserName="MUSTAFA19",
                    Email = "karadas_19@hotmail.com",PasswordHash= "AQAAAAEAACcQAAAAEMlwwNhkMLSOhQFsHy8hlleSsH79Nt+qYZQrnp1vl8VWb3WrcmxT3jA+aUq/eGxcHw==",
                    SecurityStamp = Guid.NewGuid().ToString(),NormalizedEmail="KARADAS_19@HOTMAIL.COM",EmailConfirmed=true ,ConfirmPassword = "Karadas19." },

                new AppUser { Id = 2, FirstName = "Furkan", LastName = "Aktaş", Password = "Karadas19.", UserName = "furkan19", NormalizedUserName="FURKAN19",
                    Email = "mustafa.karadas@bilgeadamboost.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEMlwwNhkMLSOhQFsHy8hlleSsH79Nt+qYZQrnp1vl8VWb3WrcmxT3jA+aUq/eGxcHw==",
                    SecurityStamp=Guid.NewGuid().ToString(),NormalizedEmail= "MUSTAFA.KARADAS@BILGEADAMBOOST.COM",EmailConfirmed=true ,ConfirmPassword = "Karadas19." }
                
                );

        }
    }
}
