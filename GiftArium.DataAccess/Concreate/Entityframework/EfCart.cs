using GiftArium.DataAccess.Abstarct;
using GiftArium.DataAccess.DBContext;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Concreate.Entityframework
{
    public class EfCart:EfRepository<Cart,GiftAriumDBContext>,ICartDAL
    {
        GiftAriumDBContext context;
        public EfCart(GiftAriumDBContext dbContext) :base (dbContext)
        {
            context = dbContext;
        }

    }
}
