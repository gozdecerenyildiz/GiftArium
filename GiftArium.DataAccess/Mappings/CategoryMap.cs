using GiftArium.DataAccess.DBContext;
using GiftArium.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired() ;
            builder.HasIndex(x => x.CategoryName).IsUnique() ;
        }
    }
}
