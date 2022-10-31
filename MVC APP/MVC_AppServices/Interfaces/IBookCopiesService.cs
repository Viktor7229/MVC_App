using MVC_App_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Interfaces
{
    public interface IBookCopiesService
    {
        void Create(BookCopies entity);
        void Update(BookCopies entity);
        List<BookCopies> GetAll();
        void Delete(int id);
    }
}
