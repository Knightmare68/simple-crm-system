using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
namespace DAL
{
    public interface IDAL<T,TKey>
    {
        void Add(T t);
        void Update(T t);
        void Delete(TKey id);
        IList<T> GetList();
        T GetByID(TKey id);

    }
}
