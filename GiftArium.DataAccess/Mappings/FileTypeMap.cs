using GiftArium.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Mappings
{
    internal class FileTypeMap : IEntityTypeConfiguration<FileType>
    {
        public void Configure(EntityTypeBuilder<FileType> builder)
        {
            builder.Property(x=>x.FileTypeName).IsRequired().HasColumnType("nvarchar(20)"); 
            builder.HasIndex(x => x.FileTypeName).IsUnique();  
        }
    }
}
