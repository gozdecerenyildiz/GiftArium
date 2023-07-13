using GiftArium.Core;
using GiftArium.Core.DAL;
using GiftArium.DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.DataAccess.Concreate.Entityframework
{
    public class EfRepository<TEntity, TDBContext> : IRepository<TEntity> where TEntity : class,IBaseEntity,new() where TDBContext:DbContext
    {
        TDBContext dbContext;

        public EfRepository(GiftAriumDBContext dbContext1)
        {
            this.dbContext = dbContext;
        }

        public bool Add(TEntity entity)
        {
            this.dbContext = dbContext;
            dbContext.Add(entity);
            var result = dbContext.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool Delete(TEntity entity)
        {
            dbContext.Update(entity);
            return dbContext.SaveChanges() > 0 ? true : false;

        }

        public TEntity Get(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Get()
        {
            return dbContext.Set<TEntity>();
        }

        public bool Update(TEntity entity)
        {
            dbContext.Update(entity);
            return dbContext.SaveChanges() > 0 ? true : false;
        }
    }
}
