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
    public class LendingRepository : ILendingRepository
    {
        private readonly MVC_AppDbContext _db;

        public LendingRepository(MVC_AppDbContext db)
        {
            _db = db;
        }
        
        public void Create(Lending entity)
        {
            _db.Lending.Add(entity);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            Lending lending = _db.Lending.FirstOrDefault(x => x.Id == id);
            _db.Lending.Remove(lending);
            _db.SaveChanges();
        }
        public List<Lending> GetAll()
        {
            return _db.Lending.ToList();
        }
        public void Update(Lending entity)
        {
            _db.Lending.Update(entity);
            _db.SaveChanges();
        }
    }
}
