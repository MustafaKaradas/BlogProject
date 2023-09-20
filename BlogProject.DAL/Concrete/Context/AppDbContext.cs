using BlogProject.DAL.Concrete.Context.EntityConfiguration;
using BlogProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete.Context
{

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTypeConfiguration());
            
        }

        public virtual DbSet<Article> Articles { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

       
    }
}
