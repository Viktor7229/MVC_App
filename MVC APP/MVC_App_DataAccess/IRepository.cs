using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_DataAccess
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update (T entity);
        List<T> GetAll();

        void Delete(int id);
    }
}
