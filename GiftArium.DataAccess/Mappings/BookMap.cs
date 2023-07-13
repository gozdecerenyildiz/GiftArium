using GiftArium.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GiftArium.DataAccess.Mappings
{
    internal class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
           builder.Property(x=>x.BookName).HasColumnName("Name").HasColumnType("nvarchar(150)").IsRequired();  //x book u temsil etmekte.IsRequired boş geçilemesin anlamındadır.
        }
    }
}
