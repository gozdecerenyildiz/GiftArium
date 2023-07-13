using GiftArium.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Entity.POCO
{
    public class Book:BaseEntity
    {
        public string BookName { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<BookCategory> BookCategory { get; set; }
        public virtual ICollection<BookFileType> BookFileType { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual Image Image { get; set; }


    }
}
