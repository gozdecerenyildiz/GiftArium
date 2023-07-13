using GiftArium.DataAccess.Abstarct;
using GiftArium.DataAccess.DBContext;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Concreate.Entityframework
{
    internal class EfCategory : EfRepository<Category,GiftAriumDBContext>,ICategoryDAL  
    {
        GiftAriumDBContext context ;
        public EfCategory(GiftAriumDBContext context):base(context)
        {
            this.context = context; //context= dbContext diyede bilirdik
        }

    }
}
