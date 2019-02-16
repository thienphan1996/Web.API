using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPI.Interface
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);

        IEnumerable<T> List();

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
