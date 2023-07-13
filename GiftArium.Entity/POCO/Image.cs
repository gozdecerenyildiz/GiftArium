using GiftArium.Core;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Entity.POCO
{
    public class Image:BaseEntity
    {
        public int BookId { get; set; }
        public string ImageURL { get; set; }
        public  ICollection<Book> Book { get; set; }

    }
}
