using GiftArium.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Entity.POCO
{
    public class FileType:BaseEntity
    {
        public string FileTypeName { get; set; }
        public virtual ICollection<BookFileType> BookFileType { get; set; }  
    }
}
