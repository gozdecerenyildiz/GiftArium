using GiftArium.DataAccess.Abstarct;
using GiftArium.DataAccess.DBContext;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Concreate.Entityframework
{
    internal class EfBook :EfRepository<Book,GiftAriumDBContext>,IBookDAL   
    {
        GiftAriumDBContext context ;
        public EfBook(GiftAriumDBContext dbContext) :base(dbContext)
        {
            context = dbContext;
        }
    }
}
