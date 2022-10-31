using MVC_App_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Interfaces
{
    public interface IBookService
    {
        void Create(Book entity);
        void Update(Book entity);
        List<Book> GetAll();
        void Delete(int id);
    }
}
