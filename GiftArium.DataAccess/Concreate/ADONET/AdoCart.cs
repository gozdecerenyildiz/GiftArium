﻿using GiftArium.DataAccess.Abstarct;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Concreate.ADONET
{
    internal class AdoCart : ICartDAL
    {
        public bool Add(Cart entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Cart entity)
        {
            throw new NotImplementedException();
        }

        public Cart Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> Get()
        {
            throw new NotImplementedException();
        }

        public bool Update(Cart entity)
        {
            throw new NotImplementedException();
        }
    }
}
