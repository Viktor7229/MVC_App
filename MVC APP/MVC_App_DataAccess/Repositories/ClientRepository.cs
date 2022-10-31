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
    public class ClientRepository : IClientRepository
    {
        private readonly MVC_AppDbContext _db;

        public ClientRepository(MVC_AppDbContext db)
        {
            _db = db;
        }   

        public void Create (Client entity)
        {
            _db.Client.Add(entity);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            Client client = _db.Client.FirstOrDefault(x => x.Id == id);
            _db.Client.Remove(client);
            _db.SaveChanges();
        }
        public List <Client> GetAll()
        {
            return _db.Client.ToList();
        }
        public void Update(Client entity)
        {
            _db.Client.Update(entity);
            _db.SaveChanges();
        }
    }
}
