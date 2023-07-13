using GiftArium.Core;
using GiftArium.DataAccess.Mappings;
using GiftArium.Entity.POCO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.DBContext
{
    public class GiftAriumDBContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.\\MSSQLSERVER; Database = GiftAriumDB; Trusted_Connection = True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BookMap());
            builder.ApplyConfiguration(new CategoryMap());  
            builder.ApplyConfiguration(new BookCategoryMap());
            builder.ApplyConfiguration(new CartMap());
            builder.ApplyConfiguration(new BookFileTypeMap());
            builder.ApplyConfiguration(new FileTypeMap());
            builder.ApplyConfiguration(new ImageMap());


            base.OnModelCreating(builder);
        }
        public DbSet <Book> Books { get; set; }
        public DbSet <BookCategory> BookCategories { get; set; }
        public DbSet <BookFileType> BookFileTypes { get; set; }
        public DbSet <Cart> Carts { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet <FileType> FileTypes { get; set; }
        public DbSet <Image> Images { get; set; }






    }
}
