﻿using GiftArium.DataAccess.Abstarct;
using GiftArium.DataAccess.DBContext;
using GiftArium.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Concreate.Entityframework
{
    internal class EfImage :EfRepository<Image,GiftAriumDBContext>,IImageDAL
    {
        GiftAriumDBContext context;
        public EfImage(GiftAriumDBContext dbContext) :base(dbContext)
        {
            context = dbContext;
        }
    }
}
