using GiftArium.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Mappings
{
    internal class BookCategoryMap : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.Property(x=>x.CategoryId).IsRequired();
            builder.Property(x=>x.BookId).IsRequired(); 
            
        }
    }
}
