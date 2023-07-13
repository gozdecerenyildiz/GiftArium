using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Core.DAL
{
    public interface IRepository<TEntity> where TEntity : class,IBaseEntity,new()
    {
        bool Add(TEntity entity);
        bool Delete(TEntity entity);
        bool Update(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
    }
}
