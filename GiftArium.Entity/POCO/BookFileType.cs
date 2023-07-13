using GiftArium.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Entity.POCO
{
    public class BookFileType:IBaseEntity
    {
        public int Id { get; set; } 
        public int  BookId { get; set; }
        public int  FileTypeId { get; set; }
        public virtual Book Book { get; set; }
        public virtual FileType FileType { get; set; }
      
    }
}
