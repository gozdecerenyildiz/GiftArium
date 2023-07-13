using GiftArium.BussinesLogicLayer.Abstract;
using GiftArium.Core.BLL.Logger;
using GiftArium.DataAccess.Abstarct;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Concreate
{
    internal class BookManager : IBookService
    {
        IBookDAL bookDAL;
        public BookManager (IBookDAL dAL)
        {
            bookDAL = dAL;
        }
        public bool Add(Book entity)
        {
            try
            {
                //bunun yapılmasındaki amaç veriyi ekle metoduna gönder eğer işlemim başarılı ise true değilse false
                bool result=bookDAL.Add(entity);
                if(result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookName}isimli kitap eklendi.",LogType.Insert);
                    return true;
                }  
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookName}isimli kitap eklenemedi.", LogType.NonValidation);//eklenemedi
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message,LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public bool Delete(Book entity)
        {
            try
            {
                
                bool result = bookDAL.Delete(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookName}isimli kitap silindi.", LogType.Delete);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookName}isimli kitap silinemedi.", LogType.NotFound);//silinemdi
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public Book Get(int id)
        {
            try
            {
                var result = bookDAL.Get(id);
                return result;

            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public IEnumerable<Book> Get()
        {
            try
            {
                
                var result = bookDAL.Get();
                return result;
                
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public bool Update(Book entity)
        {
            try
            {
                //bunun yapılmasındaki amaç veriyi ekle metoduna gönder eğer işlemim başarılı ise true değilse false
                bool result = bookDAL.Update(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookName}isimli kitap güncellendi.", LogType.Update);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookName}isimli kitap güncellenemdi.", LogType.NonValidation);//eklenemedi
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
