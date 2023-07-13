using GiftArium.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Entity.POCO
{
    public  class Cart:BaseEntity
    {
        public int AppUserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public virtual Book  Book { get; set; }
        public virtual AppUser AppUser { get; set; }


    }
}
