using GiftArium.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Mappings
{
    public class BookFileTypeMap : IEntityTypeConfiguration<BookFileType>
    {
        public void Configure(EntityTypeBuilder<BookFileType> builder)
        {
            builder.Property(x=>x.FileTypeId).IsRequired();
            builder.Property(x =>x.BookId).IsRequired();


        }
    }
}
