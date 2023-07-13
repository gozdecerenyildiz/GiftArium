using GiftArium.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Mappings
{
    internal class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(x => x.BookId).IsRequired();
            builder.Property(x => x.ImageURL).IsRequired().HasColumnType("nvarchar(MAX)");
           // builder.HasIndex(x => x.ImageURL).IsUnique();
        }
    }
}
