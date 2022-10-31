using Microsoft.EntityFrameworkCore.Query.Internal;
using MVC_App.Domain;
using MVC_App_DataAccess.Interfaces;
using MVC_App_Domain;
using MVC_App_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_DataAccess.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly MVC_AppDbContext _db;

        public BookRepository(MVC_AppDbContext db)
        {
            _db = db;
        }
        public void Create (Book entity)
        {
            _db.Add(entity);
            _db.SaveChanges();

        }
        public void Delete(int id)
        {
            Book book = _db.Book.FirstOrDefault(x => x.Id == id);
            _db.Remove(book);
            _db.SaveChanges();
        }
        public List<Book> GetAll()
        {
            return _db.Book.ToList();
        }
        public void Update(Book entity)
        {
            _db.Book.Update(entity);
            _db.SaveChanges();
        }
    }
}
