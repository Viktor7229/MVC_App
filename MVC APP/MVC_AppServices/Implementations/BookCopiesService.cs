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
    public class BookCopiesService : IBookCopiesService
    {
        private readonly IBookCopiesService _bookcopiesRepository;

        public BookCopiesService(IBookCopiesService bookcopiesRepository)
        {
            _bookcopiesRepository = bookcopiesRepository;
        }
        public void Create(BookCopies entity)
        {
            _bookcopiesRepository.Create(entity);
        }
        public void Delete(int id)
        {
            _bookcopiesRepository.Delete(id);
        }
        public List<BookCopies> GetAll()
        {
            return _bookcopiesRepository.GetAll();
        }
        public void Update(BookCopies entity)
        {
            _bookcopiesRepository.Update(entity);
        }
    }

}
