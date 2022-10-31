using MVC_APP.Models;
using MVC_App_DataAccess.Interfaces;
using MVC_App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_App_DataAccess.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly MVC_AppDbContext _db;

        public LibraryRepository(MVC_AppDbContext db)
        {
            _db = db;
        }   
        public void Create(Library entity)
        {
            _db.Library.Add(entity);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            Library library = _db.Library.FirstOrDefault(x => x.Id == id);
            _db.Library.Remove(library);
            _db.SaveChanges();
        }
        public List<Library> GetAll()
        {

        return _db.Library.ToList(); 
        }
        public void Update(Library entity)
        {
            _db.Library.Update(entity);
            _db.SaveChanges();
        }
    }
}
