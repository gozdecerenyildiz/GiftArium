using GiftArium.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Mappings
{
    internal class CartMap : IEntityTypeConfiguration<Cart>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cart> builder)
        {
            builder.Property(x=>x.AppUserId).IsRequired();
            builder.Property(x => x.BookId).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();

        }
    }
}
