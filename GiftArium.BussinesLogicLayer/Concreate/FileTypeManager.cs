using GiftArium.BussinesLogicLayer.Abstract;
using GiftArium.Core.BLL.Logger;
using GiftArium.DataAccess.Abstarct;
using GiftArium.DataAccess.Mappings;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Concreate
{
    
    internal class FileTypeManager : IFileTypeService
  
    {
        IFileTypeDAL fileTypeDAL;
        public FileTypeManager(IFileTypeDAL dAL)
        {
            fileTypeDAL = dAL;
        }

        public bool Add(FileType entity)
        {
            try
            {
                bool result = fileTypeDAL.Add(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.FileTypeName}isimli dosya tipi eklendi.", LogType.Insert);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.FileTypeName}isimli dosya tipi eklenemedi.", LogType.NonValidation);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public bool Delete(FileType entity)
        {
            try
            {
                bool result = fileTypeDAL.Delete(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.FileTypeName}isimli dosya tipi silindi.", LogType.Delete);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.FileTypeName}isimli dosya tipi silinemedi.", LogType.NotFound);
                    return false;
                }
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return false;
            }
        }

        public FileType Get(int id)
        {
            try
            {
                var result = fileTypeDAL.Get(id);
                return result;
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public IEnumerable<FileType> Get()
        {
            try
            {
               var result = fileTypeDAL.Get();  
                return result;  
            }
            catch (Exception e)
            {
                GiftAriumLogger.AddLog(e.Message, LogType.Error);//hata ile karşılaşıldığında
                return null;
            }
        }

        public bool Update(FileType entity)
        {
            try
            {
                bool result = fileTypeDAL.Update(entity);
                if (result)
                {
                    GiftAriumLogger.AddLog($"{entity.FileTypeName}isimli dosya tipi güncellendi.", LogType.Update);
                    return true;
                }
                else
                {
                    GiftAriumLogger.AddLog($"{entity.FileTypeName}isimli dosya tipi güncellenemedi.", LogType.NonValidation);
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
