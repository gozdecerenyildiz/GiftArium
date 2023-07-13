using GiftArium.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Entity.POCO
{
    public class BookCategory : IBaseEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public virtual Book Book { get; set; }
        public virtual Category Category { get; set; }
    }
   
}
