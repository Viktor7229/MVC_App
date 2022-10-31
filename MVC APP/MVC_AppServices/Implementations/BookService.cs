using MVC_App_Domain.Models;
using MVC_AppServices.Interfaces;
using MVC_App_DataAccess.Interfaces;
using MVC_App_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_AppServices.Implementations
{
    public class BookService : IBookService
    {
        private readonly IBookService _bookRepository;
   
        public BookService(IBookService bookRepository)
        {
            _bookRepository = bookRepository;
        }   
        public void Create(Book entity)
        {
            _bookRepository.Create(entity);
        }
        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }
        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }
        public void Update(Book entity)
        {
            _bookRepository.Update(entity);
        }
    }


}
