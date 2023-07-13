using GiftArium.DataAccess.Abstarct;
using GiftArium.DataAccess.DBContext;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Concreate.Entityframework
{
    internal class EfBookCategory : EfRepository<BookCategory,GiftAriumDBContext>
    {
        GiftAriumDBContext context = new GiftAriumDBContext();
        public EfBookCategory(GiftAriumDBContext context):base(context)
        {
            
        }
    }
}
