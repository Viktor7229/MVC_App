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
    public class PublisherRepository : IPublisherRepository
    {
        private readonly MVC_AppDbContext _db;

        public PublisherRepository(MVC_AppDbContext db)
        {
            _db = db;
        }   
        public void Create(Publisher entity)
        {
            _db.Publisher.Add(entity);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            Publisher publisher = _db.Publisher.FirstOrDefault(x => x.Id == id);
            _db.Publisher.Remove(publisher);
            _db.SaveChanges();
        }
        public List<Publisher> GetAll()
        {
            return _db.Publisher.ToList(); 
        }
        public void Update (Publisher entity)
        {
            _db.Publisher.Update(entity);
            _db.SaveChanges();
        }
    }
}
