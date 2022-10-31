using MVC_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Interfaces
{
    public interface ILibraryService
    {
        void Create(Library entity);
        void Update(Library entity);
        List<Library> GetAll();
        void Delete(int id);
    }
}
