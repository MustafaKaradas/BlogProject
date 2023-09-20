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
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.Property(x => x.CategoryName)
                    .IsRequired()
                    .HasColumnName("Category Name");

            builder.HasData(
                new Category {Id=1,CategoryName="İstatistik",ImagePath= @"\images\category\istatistik.png", CreatedBy="Admin",CreatedDate=DateTime.Now,IsDeleted=false },
                new Category {Id=2,CategoryName="Teknoloji", ImagePath = @"\images\category\teknoloji.jpg", CreatedBy="Admin",CreatedDate=DateTime.Now,IsDeleted=false },
                new Category {Id=3,CategoryName="Hukuk", ImagePath = @"\images\category\hukuk.jpg", CreatedBy="Admin",CreatedDate=DateTime.Now,IsDeleted=false },
                new Category {Id=4,CategoryName="Felsefe", ImagePath = @"\images\category\felsefe.jpg", CreatedBy="Admin",CreatedDate=DateTime.Now,IsDeleted=false },
                new Category {Id=5,CategoryName="Spor", ImagePath = @"\images\category\sporr.jpg", CreatedBy="Admin",CreatedDate=DateTime.Now,IsDeleted=false },
                new Category {Id=6,CategoryName="Psikoloji", ImagePath = @"\images\category\psikoloji.jpg", CreatedBy="Admin",CreatedDate=DateTime.Now,IsDeleted=false }






                );
        }
    }
}
