using GiftArium.BussinesLogicLayer.Abstract;
using GiftArium.Core.BLL.Logger;
using GiftArium.DataAccess.Abstarct;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Concreate
{
    internal class BookFileTypeManager : IBookFileTypeService
    {
        IBookFileTypeDAL bookFileType;
        public BookFileTypeManager(IBookFileTypeDAL dAL)
        {
            bookFileType = dAL;
        }
        public bool Add(BookFileType entity)
        {
            try
            {

                bool result = bookFileType.Add(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}ıd değerine sahip kitap {entity.FileTypeId}ıd değerine sahip olan dosya tipi ile eşleştirildi.", LogType.Insert);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli dosya ile eşleştirilemedi.", LogType.NonValidation);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public bool Delete(BookFileType entity)
        {
            try
            {

                bool result = bookFileType.Delete(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}ıd değerine sahip kitap {entity.FileTypeId}ıd değerine sahip olan kategori ile eşleştirilmesi kaldırıldı.", LogType.Delete);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitap eşleştirilmesi kaldırılamadı.", LogType.NotFound);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public BookFileType Get(int id)
        {
            try
            {
                var result = bookFileType.Get(id);
                return result;

            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public IEnumerable<BookFileType> Get()
        {
            try
            {
                var result = bookFileType.Get();
                return result;
                
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public bool Update(BookFileType entity)
        {
            try
            {

                bool result = bookFileType.Update(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}ıd değerine sahip kitap {entity.FileTypeId}ıd değerine sahip olan kategori ile eşleştirilmesi güncellendi.", LogType.Update);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitap eşleştirilmesi güncellenemedi.", LogType.NonValidation);
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
