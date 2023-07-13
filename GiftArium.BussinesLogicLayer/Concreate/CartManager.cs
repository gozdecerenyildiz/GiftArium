using GiftArium.BussinesLogicLayer.Abstract;
using GiftArium.Core.BLL.Logger;
using GiftArium.DataAccess.Abstarct;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Concreate
{
    internal class CartManager : ICartService
    {
        ICartDAL cartDAL;
        public CartManager (ICartDAL dAL)
        {
            cartDAL = dAL;
        }
        public bool Add(Cart entity)
        {
            try
            {
                bool result = cartDAL.Add(entity);
                return result;

            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public bool Delete(Cart entity)
        {
            try
            {
                bool result = cartDAL.Delete(entity);
                return result;

            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public Cart Get(int id)
        {
            try
            {
                var result = cartDAL.Get(id);
                return result;

            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public IEnumerable<Cart> Get()
        {
            try
            {
                var result = cartDAL.Get();
                return result;

            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public bool Update(Cart entity)
        {
            try
            {
                bool result = cartDAL.Update(entity);
                return result;

            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }
    }
}
