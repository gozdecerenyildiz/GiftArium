using GiftArium.BussinesLogicLayer.Abstract;
using GiftArium.Core.BLL.Logger;
using GiftArium.DataAccess.Abstarct;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Concreate
{
    internal class CategoryManager : ICategoryService
    {
        ICategoryDAL categoryDAL;
        public CategoryManager(ICategoryDAL dAL)
        {
            categoryDAL = dAL;
        }
        public bool Add(Category entity)
        {
            try
            {
                bool result = categoryDAL.Add(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.CategoryName}isimli kitap kategorisi eklendi.", LogType.Insert);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.CategoryName}isimli kitap kategorisi eklenemedi.", LogType.NonValidation);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public bool Delete(Category entity)
        {
            try
            {
                bool result = categoryDAL.Delete(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.CategoryName}isimli kitap kategori silindi.", LogType.Delete);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.CategoryName}isimli kitap kategori silinemedi.", LogType.NotFound);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public Category Get(int id)
        {
            try
            {
                var result = categoryDAL.Get(id);
                return result;
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public IEnumerable<Category> Get()
        {
            try
            {
                var result = categoryDAL.Get();
                return result;  
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public bool Update(Category entity)
        {
            try
            {
                bool result = categoryDAL.Update(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.CategoryName}isimli kitap kategorisi güncellendi.", LogType.Update);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.CategoryName}isimli kitap kategorisi güncellenemedi.", LogType.NonValidation);
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
