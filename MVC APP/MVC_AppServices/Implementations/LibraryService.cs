using MVC_App_Domain.Models;
using MVC_AppServices.Interfaces;
using MVC_App_DataAccess.Interfaces;
using MVC_App_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_APP.Models;

namespace MVC_AppServices.Implementations
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryService _libraryRepository;

        public LibraryService(ILibraryService libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }   
        public void Create(Library entity)
        {
            _libraryRepository.Create(entity);
        }
        public void Delete(int id)
        {
            _libraryRepository.Delete(id);
        }
        public List<Library> GetAll()
        {
            return _libraryRepository.GetAll();
        }
        public void Update(Library entity)
        {
            _libraryRepository.Update(entity);  
        }
    }
}
