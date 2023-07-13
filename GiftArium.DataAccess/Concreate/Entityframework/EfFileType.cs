using GiftArium.DataAccess.Abstarct;
using GiftArium.DataAccess.DBContext;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Concreate.Entityframework
{
    internal class EfFileType : EfRepository<FileType,GiftAriumDBContext>,IFileTypeDAL
    {
        GiftAriumDBContext context = new GiftAriumDBContext();
        public EfFileType(GiftAriumDBContext dbContext) :base(dbContext)
        {
            context = dbContext;
        }
    }
}
