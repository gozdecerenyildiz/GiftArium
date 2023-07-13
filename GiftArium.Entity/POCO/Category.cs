using GiftArium.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Entity.POCO
{
    public  class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual ICollection <BookCategory> BookCategory { get; set;}
    }
}
