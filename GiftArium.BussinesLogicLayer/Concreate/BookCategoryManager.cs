using GiftArium.BussinesLogicLayer.Abstract;
using GiftArium.Core.BLL.Logger;
using GiftArium.DataAccess.Abstarct;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Concreate
{
    internal class BookCategoryManager : IBookCategoryService
    {
        IBookCategoryDAL bookCategorDAL;
        public BookCategoryManager(IBookCategoryDAL dAL) 
        {
            bookCategorDAL = dAL;
        }

        public bool Add(BookCategory entity)
        {
            try
            {

                bool result = bookCategorDAL.Add(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}ıd değerine sahip kitap {entity.CategoryId}ıd değerine sahip olan kategori ile eşleştirildi.", LogType.Insert);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}isimli kitap eşleştirilemedi.", LogType.NonValidation);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public bool Delete(BookCategory entity)
        {
            try
            {

                bool result = bookCategorDAL.Delete(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}ıd değerine sahip kitap {entity.CategoryId}ıd değerine sahip olan kategori ile kaldırıldı.", LogType.Delete);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}ıd değerine sahip kitap {entity.CategoryId}ıd değerine sahip olan kategori ile kaldırılamadı", LogType.NotFound);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public BookCategory Get(int id)
        {
            try
            {

                var result = bookCategorDAL.Get(id);
                return result;
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public IEnumerable<BookCategory> Get()
        {
            try
            {

                var result = bookCategorDAL.Get();
                return result;
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public bool Update(BookCategory entity)
        {
            try
            {

                bool result = bookCategorDAL.Update(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}ıd değerine sahip kitap {entity.CategoryId}ıd değerine sahip olan kategori ile güncellendi", LogType.Update);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.BookId}ıd değerine sahip kitap {entity.CategoryId}ıd değerine sahip olan kategori ile güncellenemedi", LogType.NonValidation);
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
