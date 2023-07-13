using GiftArium.BussinesLogicLayer.Abstract;
using GiftArium.Core.BLL.Logger;
using GiftArium.DataAccess.Abstarct;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Concreate
{
    internal class ImageManager : IImageService

    {
        IImageDAL ımageDAL;
        public ImageManager (IImageDAL dAL)
        {
            ımageDAL = dAL;
        }
        public bool Add(Image entity)
        {
            try
            {
                bool result = ımageDAL.Add(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitabın fotoğrafı eklendi.", LogType.Insert);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitabın fotoğrafı eklenemedi.", LogType.NonValidation);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public bool Delete(Image entity)
        {
            try
            {
                bool result = ımageDAL.Delete(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitabın fotoğrafı silindi.", LogType.Delete);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitabın fotoğrafı silinemedi.", LogType.NotFound);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public Image Get(int id)
        {
            try
            {
                var result = ımageDAL.Get(id);
                return result;
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public IEnumerable<Image> Get()
        {
            try
            {
                var result = ımageDAL.Get();
                return result;
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public bool Update(Image entity)
        {
            try
            {
                bool result = ımageDAL.Update(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitabın fotoğrafı güncellendi.", LogType.Update);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitabın fotoğrafı güncellenemedi.", LogType.NonValidation);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }
    }
}
