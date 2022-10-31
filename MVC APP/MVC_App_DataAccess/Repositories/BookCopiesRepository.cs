using MVC_App_DataAccess.Interfaces;
using MVC_App_Domain.Models;
using MVC_App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_DataAccess.Repositories
{
    public class BookCopiesRepository : IBookCopiesRepository

    {
        
        private readonly MVC_AppDbContext _db;

    
    public BookCopiesRepository(MVC_AppDbContext db)
    {
        _db = db;
    }

        public void Create (BookCopies entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            BookCopies bookcopies = _db.BookCopies.FirstOrDefault(x => x.Id == id);
            _db.Remove(bookcopies);
            _db.SaveChanges();
        }
        public List<BookCopies> GetAll()
        {
            return _db.BookCopies.ToList();
        }
        public void Update(BookCopies entity)
        {
            _db.BookCopies.Update(entity);
            _db.SaveChanges();
        }
    }
}
