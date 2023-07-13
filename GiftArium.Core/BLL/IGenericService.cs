using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.Core.BLL
{
    public interface IGenericService<T>
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T Get(int id);
        IEnumerable<T> Get();
    }
}
